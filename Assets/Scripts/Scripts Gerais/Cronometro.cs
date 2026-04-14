using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public float tempo = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tempo = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {
            Debug.Log("Fim de Jogo");
        }

        if (tempo <= 0)
        {
            tempo = 15f;
        }
    }
}
