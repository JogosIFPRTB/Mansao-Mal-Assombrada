using UnityEngine;

public class ChaoMov : MonoBehaviour
{
    public float velocidade = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        if(transform.position.y <= -7)
        {
            transform.position = new Vector2(0, 6);
        }
    }
}
