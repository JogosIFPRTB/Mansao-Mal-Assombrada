
using UnityEngine;
using TMPro;

public class notaJogo : MonoBehaviour
{
    public float hitTime = 3f;
    public float amarelo = 0.15f;
    public float azul = 0.25f;
    public float vermelho = 0.35f;
    private bool washit = false;
    private SpriteRenderer sr;
    public KeyCode key;
    [SerializeField] public int pontos = 0;
    [Header("Referências da UI")]
    [SerializeField] private TextMeshProUGUI textoPontosUI;

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
           // hit();
            pontos++;

            AtualizarPlacar();
        }
        else if (difference <= azul)
        {
            SetColor(Color.blue);
            Debug.Log("arzur");
           // hit();
            pontos++;

            AtualizarPlacar();

        }
        else if (difference <= vermelho)
        {
            SetColor(Color.red);
            Debug.Log("veimei");
            //hit();
            pontos++;

            AtualizarPlacar();
        }
        else
        {
            Debug.Log("erro");
            pontos--;
            AtualizarPlacar();
        }

       
    }
    void SetColor(Color color)
    {
        sr.color = color;
    }

    public void AtualizarPlacar()
    {
        if (textoPontosUI != null)
        {
            textoPontosUI.text = "Pontos: " + pontos;
        }
    }

}
