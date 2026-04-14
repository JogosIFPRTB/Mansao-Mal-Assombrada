using UnityEngine;

public class ColisorPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D colidiu)
    {
        if (colidiu.CompareTag("Inimigo"))
        {
            Debug.Log("Você colidiu com um inimigo, cuidado...");

        }
    }
}
