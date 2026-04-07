using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOver : MonoBehaviour
{
    public string gameover = "gameOver";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Inimigo"))
        {
            SceneManager.LoadScene(gameover);
        }
    }
}
