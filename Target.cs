using UnityEngine;

public class Target : MonoBehaviour
{
    public Vector3 targetPoint;
    public float speed;


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);


        if (Vector3.Distance(transform.position, targetPoint) < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}