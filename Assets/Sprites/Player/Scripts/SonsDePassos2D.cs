using UnityEngine;

public class SonsDePassos2D : MonoBehaviour
{
    [Header("Componentes")]
    public AudioSource audioSource;

    [Header("Configurações de Áudio")]
    public AudioClip[] sonsDePassos; // Sua lista com os 5 sons
    private int ultimoIndex = -1;    // Guarda o último som tocado

    [Header("Configurações de Tempo")]
    public float tempoEntrePassos = 0.4f; // Tempo entre cada pisada
    private float cronometro = 0f;

    void Update()
    {
        bool estaSeMovendo = Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0;

        if (estaSeMovendo)
        {
            cronometro += Time.deltaTime;

            if (cronometro >= tempoEntrePassos)
            {
                TocarSomAleatorio();
                cronometro = 0f;
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }

            cronometro = tempoEntrePassos;
        }
    }

    void TocarSomAleatorio()
    {
        if (sonsDePassos.Length <= 1 || audioSource == null)
        {
            // Se tiver apenas 1 som na lista, toca ele mesmo para não travar o jogo
            if (sonsDePassos.Length == 1) audioSource.PlayOneShot(sonsDePassos[0]);
            return;
        }

        int indexAleatorio;

        // Fica sorteando um som até achar um que seja diferente do último
        do
        {
            indexAleatorio = Random.Range(0, sonsDePassos.Length);
        } while (indexAleatorio == ultimoIndex);

        // Salva este som como o "último" para a próxima pisada
        ultimoIndex = indexAleatorio;

        audioSource.clip = sonsDePassos[indexAleatorio];
        audioSource.Play();
    }
}