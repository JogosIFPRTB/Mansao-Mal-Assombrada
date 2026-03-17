using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public float velocidade = 4f;
    public InputAction input;
    private Rigidbody2D rb;
    private Vector2 movimento;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable() => input.Enable();
    private void OnDisable() => input.Disable();

    void Update()
    {
        movimento = input.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 dir = movimento.normalized;
        rb.linearVelocity = dir * velocidade;
    }
}
