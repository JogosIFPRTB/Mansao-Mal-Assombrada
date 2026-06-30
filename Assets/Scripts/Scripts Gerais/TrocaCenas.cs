using UnityEngine;
using UnityEngine.SceneManagement;
public class TrocaCenas : MonoBehaviour
{
    public string JOGO1 = "concept mini game 1";
    public string jogo2 = "Mini Game Ritimo";
    public string jogo3 = "Mini Game Shooter";
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
   
       
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
}
