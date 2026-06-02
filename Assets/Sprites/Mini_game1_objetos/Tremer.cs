using UnityEngine;

public class Tremer : MonoBehaviour
{
    [Header("Configurações de Tremor")]
    public float shakeAmount = 0.1f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        
        Vector3 shakeOffset = Random.insideUnitSphere * shakeAmount;
        shakeOffset.z = 0;
        
        transform.position = new Vector3(startPos.x, startPos.z) + shakeOffset/8;
        //maior larapiedade do universo tudo ta divido por 8 pq o shake dessa merda é muito forte
    }
}