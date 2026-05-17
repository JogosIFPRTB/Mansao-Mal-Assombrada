using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTime = 2f;

    // Distância extra fora da tela
    public float extraDistance = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnTime);
    }

    void SpawnEnemy()
    {
        Camera cam = Camera.main;

        float screenHeight = cam.orthographicSize;
        float screenWidth = screenHeight * cam.aspect;

        Vector2 spawnPosition = Vector2.zero;

        // Escolhe um lado aleatório
        int side = Random.Range(0, 4);

        switch (side)
        {
            // Topo
            case 0:
                spawnPosition = new Vector2(
                    Random.Range(-screenWidth, screenWidth),
                    screenHeight + extraDistance
                );
                break;

            // Baixo
            case 1:
                spawnPosition = new Vector2(
                    Random.Range(-screenWidth, screenWidth),
                    -screenHeight - extraDistance
                );
                break;

            // Direita
            case 2:
                spawnPosition = new Vector2(
                    screenWidth + extraDistance,
                    Random.Range(-screenHeight, screenHeight)
                );
                break;

            // Esquerda
            case 3:
                spawnPosition = new Vector2(
                    -screenWidth - extraDistance,
                    Random.Range(-screenHeight, screenHeight)
                );
                break;
        }

        // Ajusta para posição da câmera
        spawnPosition += (Vector2)cam.transform.position;

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}