using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Tiro : MonoBehaviour
{
    public float velocidade = 10f;
    public float TempoDeVida = 3f;
    public AudioSource acerto;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * velocidade;
        Destroy(gameObject, TempoDeVida);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            acerto.Play();
            Destroy(collision.gameObject);
        }
        StartCoroutine(Esperar());
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(0.15f);
        Destroy(gameObject);
    }
}