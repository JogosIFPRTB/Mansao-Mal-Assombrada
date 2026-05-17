using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
    public GameObject ammoPrefab;

    public float spawnTime = 5f;

    public float minX = -8f;
    public float maxX = 8f;

    public float minY = -4f;
    public float maxY = 4f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnAmmo), 2f, spawnTime);
    }

    void SpawnAmmo()
    {
        Vector2 randomPosition = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
        );

        Instantiate(ammoPrefab, randomPosition, Quaternion.identity);
    }
}