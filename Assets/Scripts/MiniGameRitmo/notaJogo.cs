
using UnityEngine;


public class notaJogo : MonoBehaviour
{
    public float hitTime = 3f;
    public float amarelo = 0.15f;
    public float azul = 0.25f;
    public float vermelho = 0.35f;
    private bool washit = false;
    private SpriteRenderer sr;
    public KeyCode key;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(key) && !washit)
        {
            checkHit();
        }

    }
    void checkHit()
    {
        float tempocerto = gamertime.time;
        float difference = Mathf.Abs(tempocerto - hitTime);

        if (difference <= amarelo)
        {
            SetColor(Color.yellow);
            Debug.Log("amarei");
            hit();
        }
        else if (difference <= azul)
        {
            SetColor(Color.blue);
            Debug.Log("arzur");
            hit();

        }
        else if (difference <= vermelho)
        {
            SetColor(Color.red);
            Debug.Log("veimei");
            hit();
        }
        else
        {
            Debug.Log("erro");
        }

       
    }
    void SetColor(Color color)
    {
        sr.color = color;
    }
    void hit()
    {
        washit = true;
        Destroy(gameObject);
    }

}
