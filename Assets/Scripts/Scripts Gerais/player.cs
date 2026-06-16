using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class player : MonoBehaviour
{
    [Header("Configurações do Personagem")]
    public float velocidade = 4f;
    public InputAction input;
    private Rigidbody2D rb;
    private Vector2 movimiento;
    public int vidas = 3;

    [Header("Configuração de UI")]
    public TextMeshProUGUI textoVidas;

    // --- LINHAS AJUSTADAS PARA USAR O SEU CRONOMETRO PRÓPRIO ---
    private Cronometro scriptCronometro;
    private bool jogoFinalizado = false;

    private void Start()
    {
        // Encontra o script de Cronômetro que já existe na sua cena
        scriptCronometro = FindFirstObjectByType<Cronometro>();
        AtualizarTextoVidas();
    }

    void Update()
    {
        movimiento = input.ReadValue<Vector2>();

        // Checa se o seu script de cronômetro chegou a zero para dar a vitória
        if (!jogoFinalizado && scriptCronometro != null)
        {
            // Nota: Se a variável no seu script Cronometro for 'tempoRestante' ou algo assim, 
            // mude o '.tempo' abaixo para o nome exato da variável de tempo dele.
            if (scriptCronometro.tempo <= 0)
            {
                jogoFinalizado = true;

                Painel gerenciador = FindFirstObjectByType<Painel>();
                if (gerenciador != null)
                {
                    gerenciador.AtivarVitoria();
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            vidas -= 1;
            AtualizarTextoVidas();

            if (vidas <= 0)
            {
                Painel gerenciador = FindFirstObjectByType<Painel>();
                if (gerenciador != null)
                {
                    gerenciador.AtivarDerrota();
                }
            }
        }
    }

    void UpgradeVidasUI()
    {
        AtualizarTextoVidas();
    }


    void AtualizarTextoVidas()
    {
        if (textoVidas != null)
        {
            textoVidas.text = "Vidas: " + vidas;
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable() => input.Enable();
    private void OnDisable() => input.Disable();

    void FixedUpdate()
    {
        Vector2 dir = movimiento.normalized;
        rb.linearVelocity = dir * velocidade;
    }
}
