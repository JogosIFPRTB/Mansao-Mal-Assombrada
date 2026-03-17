using UnityEngine;
using UnityEngine.SceneManagement;
public class TrocaCenas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Porta1"))
        {
            // Se for um alvo, destruímos o alvo.
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.CompareTag("Porta2"))
        {
            // Se for um alvo, destruímos o alvo.
            Debug.Log("Está trancada");
        }
    }


        // Update is called once per frame
        void Update()
    {
        

    }
}
