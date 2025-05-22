using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [Header("Настройки")]
    public Transform startPoint;
    public Transform endPoint;

    public float spawnInterval = 2f;

    public GameObject targetPrefab;


    void Start()
    {
        InvokeRepeating("SpawnTarget", 0f, spawnInterval);
    }

    void SpawnTarget()
    {
        GameObject targetObject = Instantiate(targetPrefab, startPoint.position, Quaternion.identity);

        Target target = targetObject.GetComponent<Target>();

        target.targetPoint = endPoint.position;
        target.speed = Random.Range(3, 10);
    }
}