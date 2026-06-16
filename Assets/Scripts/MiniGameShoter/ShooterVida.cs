using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class ShooterVida : MonoBehaviour
{
    public int Vida = 3;
    public string nomecena;
    public TextMeshProUGUI vida;

    private void Update()
    {
        AtualizaVida();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Inimigo"))
        {
            Vida--;
        }
        if (Vida >= 0)
        {
            SceneManager.LoadScene(nomecena);
        }
    }
    void AtualizaVida()
    {
       vida.text = "Vidas: " + Vida;
    }
}
