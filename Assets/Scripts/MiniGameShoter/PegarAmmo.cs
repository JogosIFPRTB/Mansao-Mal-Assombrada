using UnityEngine;

public class PegarAmmo : MonoBehaviour
{
    public int ammoAmount = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Arma arma = collision.GetComponentInChildren<Arma>();

            if (arma != null)
            {
                arma.AdicionarMunicao(ammoAmount);
            }

            Destroy(gameObject);
        }
    }
}