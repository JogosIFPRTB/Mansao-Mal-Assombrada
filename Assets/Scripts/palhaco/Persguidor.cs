using UnityEngine;
using UnityEngine.SceneManagement;

public class Persguidor : MonoBehaviour
{
    [SerializeField] private float velocidade = 3f;
    [SerializeField] private float aumentoDeVelo = 0.1f;
    private float MaximoDeVelo = 3f;


    private float TempoAgora;

    [SerializeField] private Transform Player;

    private Transform targetPoint;

    public string gameover = "gameOver";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Player == null)
        {
            Debug.LogError("not defined");
            return;
        }
        targetPoint = Player;
        

    }

    void Update()
    {
        if (Player == null) return;

        transform.position = Vector2.MoveTowards(transform.position,
                                targetPoint.position,
                               TempoAgora * Time.deltaTime);

        TempoAgora += aumentoDeVelo * Time.deltaTime;

        TempoAgora = Mathf.Clamp(TempoAgora, velocidade, MaximoDeVelo);
        Debug.Log("Aumentando");



    }
     private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Player"))
        {
           SceneManager.LoadScene(gameover);
       }
    }


}
