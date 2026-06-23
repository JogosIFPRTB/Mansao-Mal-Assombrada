using System.Drawing;
using UnityEngine;

public class JOSE : MonoBehaviour
{
    [Header("Configurações do Inimigo")]
    public GameObject enemyPrefab; // Arraste o Prefab do inimigo aqui

    [Header("Tempo de Spawn")]
    public float spawnInterval = 2f; // Tempo em segundos entre os spawns
    private float timer;
    public float velocidade = 3.5f;
    public float limiteX = 6f;
    private static Vector2 limiteMin;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Transform pontoA;
    [SerializeField] private Transform pontoB;

    private Transform targetPoint;


    private void Start()
    {
        targetPoint = pontoA;
    }
    void Update()
    {
        // Conta o tempo
        timer += Time.deltaTime;
        if (pontoA == null || pontoB == null) return;

        // Lógica de Movimento
        transform.position = Vector2.MoveTowards(transform.position,
                                    targetPoint.position,
                                   moveSpeed * Time.deltaTime);

        // Lógica de Troca de Alvo
        if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            if (targetPoint == pontoA)
            {
                targetPoint = pontoB;
            }
            else
            {
                targetPoint = pontoA;
            }
        }


        // Se o tempo atingir o intervalo, spawna um inimigo
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f; // Reseta o cronômetro
        }
    }

    void SpawnEnemy()
    {
        // Cria o inimigo na posição do Spawner e sem rotação
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
    
}
