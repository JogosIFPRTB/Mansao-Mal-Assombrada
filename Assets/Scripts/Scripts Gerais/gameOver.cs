using UnityEngine;
using UnityEngine.SceneManagement;
public class gameOver : MonoBehaviour
{
    public string inicio = "SampleScene";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Clique()
    {
        SceneManager.LoadScene(inicio);
    }

}
