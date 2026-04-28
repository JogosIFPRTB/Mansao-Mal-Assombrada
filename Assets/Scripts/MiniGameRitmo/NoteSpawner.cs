using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefeb;
    public Transform Spawnpoint;
    public float[] hitTimes = { 1f, 2f, 3f };
    private int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index < hitTimes.Length)
        {
            if (gamertime.time >= hitTimes[index] - 1f)
            {
                SpawnNote(hitTimes[index]);
                index++;
            }
        }
    }
    void SpawnNote(float hitTimes)
    {
        GameObject bOLOTA = Instantiate (notePrefeb, Spawnpoint.position, Quaternion.identity);

        bOLOTA.GetComponent<bOLOTA>().hitTime = hitTimes;
    }
}
