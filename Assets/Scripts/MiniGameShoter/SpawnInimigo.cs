using UnityEngine;

public class SpawnInimigo : MonoBehaviour
{
    public GameObject PrefabInimigo;
    public Transform spawnInimigo;
    public float TempoDeSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        TempoDeSpawn += Time.deltaTime;
        if (TempoDeSpawn >= 2f)
        {
            Instantiate(PrefabInimigo, spawnInimigo.position, spawnInimigo.rotation);
            TempoDeSpawn = 0f;
        }
    }
}
