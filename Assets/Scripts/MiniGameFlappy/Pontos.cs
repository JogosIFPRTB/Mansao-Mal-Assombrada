using UnityEngine;

public class Pontos : MonoBehaviour
{
    public float velocidade = 5f;
    public float limiteInferior = -6f;
    public float spawnY = 6f;
    public float limiteX = 6f;
    private void Start()
    {

    }

    private void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);

        // 2. Checa se ele passou do limite de baixo
        if (transform.position.y < limiteInferior)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // 3. Sorteia um X aleatório entre a esquerda e a direita
        float xAleatorio = Random.Range(-limiteX, limiteX);

        // 4. Aplica a nova posição (Cria um novo Vector3)
        transform.position = new Vector3(xAleatorio, spawnY, 0);
    }
}
