using Mono.Cecil.Cil;
using UnityEngine;

public class notaJogo : MonoBehaviour
{
    public float hitTime;
    public float perfeito = 0.15f;
    public float acerta = 0.25f;
    private bool naoAcertou = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !naoAcertou) ;
        {
            checkHit();
        }

    }
    void checkHit()
    {
        float tempocerto = Cronometro.time;
        float difference = Mathf.Abs(tempocerto - hitTime);

        if (difference <= perfeito )
        {
            Debug.Log("perfeito ae truta");
        }
    }

}
