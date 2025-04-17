using UnityEngine;

public class Scratch : MonoBehaviour
{
    Vector3 targetPosition;
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        targetPosition = FindFirstObjectByType<PlayerOldMovement>().transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
