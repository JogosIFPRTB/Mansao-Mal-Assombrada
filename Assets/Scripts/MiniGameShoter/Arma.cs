using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class Arma : MonoBehaviour
{
    public GameObject PrefabBala;
    public Transform SpawnBala;
    public TextMeshProUGUI municao;

    public int Municao = 10;
    public int MunicaoAtual;
    void Start()
    {
        MunicaoAtual = Municao;  
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || MunicaoAtual > 0)
        {
            Instantiate(PrefabBala, SpawnBala.position, SpawnBala.rotation);
            MunicaoAtual--;
            AtualizarMuni();
        }
        if (MunicaoAtual <= 0)
        {
            return;
        }
    }
    void AtualizarMuni()
    {
        municao.text = MunicaoAtual.ToString() + "/" + Municao.ToString();
    }
}
