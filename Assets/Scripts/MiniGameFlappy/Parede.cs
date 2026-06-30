using UnityEngine;

public class Parede : MonoBehaviour
{
    private static Vector2 limiteMin;
    private static Vector2 limiteMax;
    private static bool limitesDefinidos = false;
    public float velocidade = 5f;
    public float limiteInferior = -6f;
    public float spawnY = 6f;
    public float limiteX = 6f;
    public float lifeTime = 1620f;
    private Vector2 PosInit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Awake()
    {
        DefinirLimites();
    }
    void Start()
    {
        PosInit = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        tempopo();
        // 2. Checa se ele passou do limite de baixo
        if (lifeTime < 0)
        {
            transform.position = PosInit ;
            lifeTime = 1620f;
        }
        ;

    }
    private void DefinirLimites()
    {
        if (!limitesDefinidos)
        {
            limiteMin = new Vector2(-7f, -8.5f);  // Canto inferior esquerdo
            limiteMax = new Vector2(5.5f, 9.5f);   // Canto superior direito
            limitesDefinidos = true;
        }
    }
    private void tempopo()
    {
        lifeTime--;
    }
}

