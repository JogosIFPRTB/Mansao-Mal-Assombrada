using UnityEngine;

public class MusicasCutScenes : MonoBehaviour
{
    [SerializeField] private AudioSource somSource;
    [SerializeField] private AudioClip somEfeito;

    // Esta função será chamada diretamente pela animação
    public void TocarSomEfeito()
    {
        if (somSource != null && somEfeito != null)
        {
            somSource.PlayOneShot(somEfeito);
        }
    }
}
