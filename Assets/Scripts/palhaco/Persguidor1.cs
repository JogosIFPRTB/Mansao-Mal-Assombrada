using UnityEngine;

public class Persguidor1 : MonoBehaviour
{
    [SerializeField] private float velocidade = 3f;
    [SerializeField] private float aumentoDeVelo = 0.1f;
    private float MaximoDeVelo = 3f;


    private float TempoAgora;

    [SerializeField] private Transform Player;

    private Transform targetPoint;

    private float velo = 5f;
    private Vector2 dire;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Player == null)
        {
            Debug.LogError("not defined");
            return;
        }
        targetPoint = Player;
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
       if (Player == null) return;

        {
           transform.position = Vector2.MoveTowards(transform.position,targetPoint.position,TempoAgora * Time.deltaTime);

            TempoAgora += aumentoDeVelo * Time.deltaTime;

            TempoAgora = Mathf.Clamp(TempoAgora, velocidade, MaximoDeVelo);
            Debug.Log("Aumentando");
        }
       

    }


}
