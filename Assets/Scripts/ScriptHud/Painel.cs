using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para reiniciar a fase

public class Painel : MonoBehaviour
{
    [Header("Painéis de UI")]
    public GameObject painelPausa;
    public GameObject painelVitoria;
    public GameObject painelDerrota;

    void Update()
    {
        // Só permite pausar se as telas de fim de jogo não estiverem ativas
        if (Input.GetKeyDown(KeyCode.Escape) && !painelVitoria.activeSelf && !painelDerrota.activeSelf)
        {
            AlternarPausa();
        }
    }

    // --- PAUSA ---
    public void AlternarPausa()
    {
        if (painelPausa != null)
        {
            bool estaPausado = !painelPausa.activeSelf;
            painelPausa.SetActive(estaPausado);

            // Se o painel abrir, pausa o tempo (0). Se fechar, volta ao normal (1).
            Time.timeScale = estaPausado ? 0f : 1f;
        }
    }

    // --- VITÓRIA ---
    public void AtivarVitoria()
    {
        if (painelVitoria != null)
        {
            painelVitoria.SetActive(true);
            Time.timeScale = 0f; // Pausa o jogo
        }
    }

    // --- DERROTA ---
    public void AtivarDerrota()
    {
        if (painelDerrota != null)
        {
            painelDerrota.SetActive(true);
            Time.timeScale = 0f; // Pausa o jogo
        }
    }

    // --- BOTÕES ÚTEIS ---
    public void ReiniciarFase()
    {
        Time.timeScale = 1f; // Despausa o tempo antes de recarregar
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo"); // Apenas aparece no editor da Unity
    }
}
