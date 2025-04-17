using System.Collections;
using UnityEngine;

public class IdleState : State
{
    public ChaseState chaseState;
    public bool canSeeThePlayer;
    public override State RunCurrentState()
    {
        if (canSeeThePlayer)
        {
            return chaseState;
        }

        else
        {
            return this;
        }
    }

    public float speed;
    public Transform[] patrolPoints;
    public float waitTime;
    int currentPointIndex;

    bool once;

    // Update is called once per frame
    private void Update()
    {
        if (transform.position != patrolPoints[currentPointIndex].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
        }

        else
        {
            if (once == false)
            {
                once = true;
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        //this is basically the amount of time the cat will chill in one area before moving to the next patrol point
        yield return new WaitForSeconds(waitTime);
        if (currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
        }

        else
        {
            currentPointIndex = 0;
        }

        once = false;
    }


}





