using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Tiro : MonoBehaviour
{
    public float velocidade = 10f;
    public float TempoDeVida = 3f;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.forward * velocidade;
        Destroy(gameObject, TempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
