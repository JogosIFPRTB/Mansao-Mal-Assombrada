using UnityEngine;
using System.Collections.Generic;

public class Arma : MonoBehaviour
{
    public GameObject PrefabBala;
    public Transform SpawnBala;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Instantiate(PrefabBala, SpawnBala.position, SpawnBala.rotation);
        }
    }
    public void OnFire()
    {
        Instantiate(PrefabBala, SpawnBala.position, SpawnBala.rotation); 
    }

}
