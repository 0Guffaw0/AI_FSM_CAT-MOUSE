using UnityEngine;

public class Attack : State
{
    public GameObject scratch;
    public float timeBetweenScratches;
    private float nextScratchTime;

    public override State RunCurrentState()
    {
        Debug.Log("Meow! I have attacked!");
        return this;
    }

    private void Update()
    {
        if (Time.time > nextScratchTime)
        {
            Instantiate(scratch, transform.position, Quaternion.identity);
            nextScratchTime = Time.time + timeBetweenScratches;
        }
    }
}
