using UnityEngine;

public class InimigoCai : MonoBehaviour
{
    private static Vector2 limiteMin;
    private static Vector2 limiteMax;
    private static bool limitesDefinidos = false;
    public float velocidade = 5f;
    public float limiteInferior = -6f;
    public float spawnY = 6f;
    public float limiteX = 6f;
    public float spawnTime = 2f;

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
        if (transform.position.x == limiteMin.x) {
            Destroy(gameObject);
        };
       
    }
    private void DefinirLimites()
    {
        if (!limitesDefinidos)
        {
            limiteMin = new Vector2(-5.5f,-4.5f);  // Canto inferior esquerdo
            limiteMax = new Vector2(5.5f, 4.5f);   // Canto superior direito
            limitesDefinidos = true;
        }
    }
 
}

