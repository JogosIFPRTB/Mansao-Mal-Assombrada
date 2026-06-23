using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOver : MonoBehaviour
{
    public string gameover = "gameOver";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(gameover);
            Debug.Log("morreu");
        }
    }
}
