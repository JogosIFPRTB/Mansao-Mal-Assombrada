using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    // REMOVIDO O STATIC: Agora o tempo pertence a este GameObject específico
    [SerializeField]
    public float tempo;
    public TMP_Text textoCronometro;
    public string cena;
   
    void Update()
    {
        if (tempo > 0)
        {
            tempo -= Time.deltaTime;

            if (textoCronometro != null)
            {
                textoCronometro.text = Mathf.CeilToInt(tempo).ToString();
            }

            if (tempo <= 0)
            {
                tempo = 0; // Trava no zero para o PlayerMusica conseguir ler
                Debug.Log("Fim de Jogo");
                SceneManager.LoadScene(cena);
            }
        }
    }

    // Função pública para caso você queira resetar o cronômetro manualmente depois
    public void ReiniciarCronometro()
    {
       //tempo = 15f;
    }
}
