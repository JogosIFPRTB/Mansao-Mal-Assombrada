using UnityEngine;

public class InimigoSeguir : MonoBehaviour
{
    private Transform player;
    public float speed = 3f;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;

            transform.position += (Vector3)(direction * speed * Time.deltaTime);
        }
    }
}