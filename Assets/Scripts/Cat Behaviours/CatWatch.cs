using UnityEngine;

public class CatWatch : MonoBehaviour
{
    public float rotationSpeed;
    public float visionDistance;

    public LineRenderer lineOfSight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        lineOfSight.SetPosition(0, transform.position);

        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, visionDistance);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfSight.SetPosition(1, hitInfo.point);
            lineOfSight.endColor = Color.red;

            if (hitInfo.collider.tag == "Player")
            {
                //attack stuff here
            }
        }

        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * visionDistance, Color.green);
            lineOfSight.SetPosition(1, transform.position + transform.right * visionDistance);
            lineOfSight.startColor = Color.green;
            lineOfSight.endColor = Color.green;
        }
    }
}
