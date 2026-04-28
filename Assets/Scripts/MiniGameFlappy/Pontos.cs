using UnityEngine;

public class Pontos : MonoBehaviour
{
    private static Vector2 limiteMin;
    private static Vector2 limiteMax;
    private static bool limitesDefinidos = false;
    public float velocidade = 5f;
    public float limiteInferior = -6f;
    public float spawnY = 6f;
    public float limiteX = 6f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Awake()
    {
        DefinirLimites();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);

        // 2. Checa se ele passou do limite de baixo
        if (transform.position.y < limiteInferior)
        {
            Respawn();
        }
        if (transform.position.x == limiteMin.x)
        {
            ResetarPosicao();
        }
        ;
        void Respawn()
        {
            // 3. Sorteia um X aleatório entre a esquerda e a direita
            float xAleatorio = Random.Range(-limiteX, limiteX);

            // 4. Aplica a nova posição (Cria um novo Vector3)
            transform.position = new Vector3(xAleatorio, spawnY, 0);
        }
    }
    private void DefinirLimites()
    {
        if (!limitesDefinidos)
        {
            limiteMin = new Vector2(-6.5f, -4.5f);  // Canto inferior esquerdo
            limiteMax = new Vector2(6.5f, 3.5f);   // Canto superior direito
            limitesDefinidos = true;
        }
    }
    public static Vector2 ResetarPosicao()
    {
        return new Vector2(Random.Range(limiteMin.x, limiteMax.x), limiteMax.y);
    }
}
