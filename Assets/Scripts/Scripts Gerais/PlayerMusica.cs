using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class PlayerMusica : MonoBehaviour
{
    [System.Serializable]
    public class ConfiguracaoCena
    {
        public string nomeDaCena;
        public AudioClip musicaDeFundo;
    }

    public AudioSource emissorSom;
    public List<ConfiguracaoCena> minigames;

    [Header("Sons de Resultado")]
    public AudioClip somVitoria;
    public AudioClip somDerrota;
    public int pontosParaVencer = 500;

    private bool somFinalTocado = false;
    private player scriptDoPlayer; // Referência ao seu script do player

    void Awake()
    {
        // Garante que o som não pare ao mudar de cena (Singleton)
        if (FindObjectsOfType<PlayerMusica>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += AoCarregarCena;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= AoCarregarCena;
    }

    void AoCarregarCena(Scene cena, LoadSceneMode modo)
    {
        somFinalTocado = false;

        // Busca o script do player na nova cena
        scriptDoPlayer = FindObjectOfType<player>();

        // Verifica se a nova cena tem uma música na lista
        foreach (var config in minigames)
        {
            if (config.nomeDaCena == cena.name)
            {
                TocarAudio(config.musicaDeFundo, true);
                break;
            }
        }
    }

    void Update()
    {
        if (somFinalTocado) return;

        //// Lógica de VITÓRIA (Lendo o tempo static do seu script Cronometro)
        //if (Cronometro.tempo <= 0)
        //{
        //    TocarAudioFinal(somVitoria);
        //}

        /*
        if (scriptDoPlayer.pontos >= pontosParaVencer)
        {
            TocarAudioFinal(somVitoria);
        }
        */

        // Lógica de DERROTA (Lendo a vida do player)
        if (scriptDoPlayer != null && scriptDoPlayer.vidas <= 0)
        {
            TocarAudioFinal(somDerrota);
        }
    }

    void TocarAudioFinal(AudioClip clip)
    {
        somFinalTocado = true;
        TocarAudio(clip, false); // Toca o som de fim sem loop
    }

    void TocarAudio(AudioClip clip, bool loop)
    {
        if (emissorSom.clip == clip) return;
        emissorSom.Stop();
        emissorSom.clip = clip;
        emissorSom.loop = loop;
        emissorSom.Play();
    }
}
