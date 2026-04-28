using Mono.Cecil.Cil;
using UnityEngine;

public class notaJogo : MonoBehaviour
{
    public float hitTime = 3f;
    public float perfeito = 0.15f;
    public float acerta = 0.25f;
    private bool washit = false;
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !washit)
        {
            checkHit();
        }

    }
    void checkHit()
    {
        float tempocerto = gamertime.time;
        float difference = Mathf.Abs(tempocerto - hitTime);

        if (difference <= perfeito )
        {
            SetColor(Color.green);
            Debug.Log("perfeito ae truta");
        }
        else if (difference <= acerta )
        {
            SetColor(Color.yellow);
            Debug.Log("acertou");

        }
        else
        {
            SetColor(Color.red);
            Debug.Log("não acertou");
        }

        void SetColor(Color color)
        {
            sr.color = color;
        }
    }
    void hit()
    {
        washit = true;
        Destroy(gameObject);
    }

}
