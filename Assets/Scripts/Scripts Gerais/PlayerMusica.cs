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

    private bool somFinalTocado = false;
    private player scriptDoPlayer;
    public Cronometro scriptDoCronometro;

    void Awake()
    {
        if (FindObjectsByType<PlayerMusica>(FindObjectsSortMode.None).Length > 1)
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
        scriptDoPlayer = FindFirstObjectByType<player>();
        scriptDoCronometro = FindFirstObjectByType<Cronometro>();

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

        // CONDIÇÃO ÚNICA DE VITÓRIA: Tempo chegou a zero
        if (scriptDoCronometro != null && scriptDoCronometro.tempo <= 0)
        {
            TocarAudioFinal(somVitoria);
        }

        // Lógica de DERROTA: Vidas do player chegaram a zero
        if (scriptDoPlayer != null && scriptDoPlayer.vidas <= 0)
        {
            TocarAudioFinal(somDerrota);
        }
    }

    void TocarAudioFinal(AudioClip clip)
    {
        somFinalTocado = true;
        emissorSom.pitch = 1f;
        TocarAudio(clip, false);
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
