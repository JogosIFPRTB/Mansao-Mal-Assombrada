using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class player : MonoBehaviour
{
    public float velocidade = 4f;
    public InputAction input;
    private Rigidbody2D rb;
    private Vector2 movimento;
    public TextMeshProUGUI textoPontosUI;
    public TextMeshProUGUI textoVidasUI;
    public int vidas = 3;
    public int pontos = 0;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable() => input.Enable();
    private void OnDisable() => input.Disable();

    void Update()
    {
        movimento = input.ReadValue<Vector2>();
        atualizarUI();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 dir = movimento.normalized;
        rb.linearVelocity = dir * velocidade;
    }
    void atualizarUI() {
        textoPontosUI.text = "Pontos: " + pontos;
        textoVidasUI.text = "Vidas: " + vidas;
    }
    void OnTriggerEnter2D(Collider2D colidiu)
    {
        if (colidiu.CompareTag("Inimigo"))
        {
            Debug.Log("Você colidiu com um inimigo, cuidado...");
            vidas--;
        }
        if (colidiu.CompareTag("PontoF"))
        {
            Debug.Log("Você atingiu uma moeda, ganhaste pontos");
            pontos = pontos + 100;
        }
    }
}
