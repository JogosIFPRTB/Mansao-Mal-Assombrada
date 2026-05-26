using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    // REMOVIDO O STATIC: Agora o tempo pertence a este GameObject específico
    [SerializeField]
    public float tempo;
    public TMP_Text textoCronometro;

   
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
            }
        }
    }

    // Função pública para caso você queira resetar o cronômetro manualmente depois
    public void ReiniciarCronometro()
    {
       //tempo = 15f;
    }
}
