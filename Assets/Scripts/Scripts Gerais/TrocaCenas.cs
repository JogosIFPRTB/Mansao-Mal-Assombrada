using UnityEngine;
using UnityEngine.SceneManagement;
public class TrocaCenas : MonoBehaviour
{
    public string JOGO1 = "SampleScene";
    public string jogo2 = "TESTE";
    public string jogo3 = "TESTE2";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("aipapai");
       
        if (other.CompareTag("Porta1"))
        {

            SceneManager.LoadScene(JOGO1);
        }
        if(other.CompareTag("Porta2"))
        {
            SceneManager.LoadScene(jogo2);
        }
        if (other.CompareTag("Porta3"))
        {
            SceneManager.LoadScene(jogo3);
        }
    }


    // Update is called once per frame
    void Update()
    {
        

    }
}
