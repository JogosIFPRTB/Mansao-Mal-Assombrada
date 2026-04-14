using System.Threading;
using UnityEngine;
using TMPro;

public class gamertime : MonoBehaviour
{
    public static float time;
    public TMP_Text timertexto;
   
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 3f)
        {
            time = 0;
        }
        timertexto.text = "tempo: " + time.ToString("F2");
    }
  
}
