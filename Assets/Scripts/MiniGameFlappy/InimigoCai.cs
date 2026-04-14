using UnityEngine;

public class InimigoCai : MonoBehaviour
{
    private static Vector2 limiteMin;
    private static Vector2 limiteMax;
    private static bool limitesDefinidos = false;

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
        if (transform.position.x == limiteMin.x) {
            ResetarPosicao();
        };
    }
    private void DefinirLimites()
    {
        if (!limitesDefinidos)
        {
            limiteMin = new Vector2(-6.5f,-4.5f);  // Canto inferior esquerdo
            limiteMax = new Vector2(6.5f, 3.5f);   // Canto superior direito
            limitesDefinidos = true;
        }
    }
    public static Vector2 ResetarPosicao()
    {
        return new Vector2(Random.Range(limiteMin.x, limiteMax.x), limiteMax.y);
    }
}
