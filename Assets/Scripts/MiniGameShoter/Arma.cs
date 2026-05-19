using UnityEngine;
using TMPro;

public class Arma : MonoBehaviour
{
    public GameObject PrefabBala;
    public Transform SpawnBala;
    public TextMeshProUGUI municao;

    public int Municao = 10;
    private int MunicaoAtual;

    void Start()
    {
        MunicaoAtual = Municao;
        AtualizarMuni();
    }

    void Update()
    {
        // Só atira se apertar espaço E tiver munição
        if (Input.GetKeyDown(KeyCode.Space) && MunicaoAtual > 0)
        {
            Instantiate(PrefabBala, SpawnBala.position, SpawnBala.rotation);

            MunicaoAtual--;

            AtualizarMuni();
        }
    }

    public void AdicionarMunicao(int quantidade)
    {
        MunicaoAtual += quantidade;
        // Limite máximo
        if (MunicaoAtual > Municao)
        {
            MunicaoAtual = Municao;
        }
        AtualizarMuni();
    }

    void AtualizarMuni()
    {
        municao.text = MunicaoAtual + "/" + Municao;
    }
}