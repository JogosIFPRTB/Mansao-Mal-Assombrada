using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaTelas : MonoBehaviour
{
   public string nomecena = "NomeCena";

   public void TrocarCena(string nomecena)
   {
      SceneManager.LoadScene(nomecena);
        
   } 
    public void sair ()
    {
        Application.Quit();
    }
}
