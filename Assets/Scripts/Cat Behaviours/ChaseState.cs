using UnityEngine;

public class ChaseState : State
{
    public Attack attackState;
    public bool isInAttackRange;
    public override State RunCurrentState()
    {
        if (isInAttackRange)
        {
            return attackState;

        }

        else
        {
            return this;
        }
    }

    public float speed;
    public Transform target;
    public float minimumDistance;

    public GameObject scratch;
    public float timeBetweenScratches;
    private float nextScratchTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextScratchTime)
        {
            Instantiate(scratch, transform.position, Quaternion.identity);
            nextScratchTime = Time.time + timeBetweenScratches;
        }


        if (Vector2.Distance(transform.position, target.position) > minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }
}
