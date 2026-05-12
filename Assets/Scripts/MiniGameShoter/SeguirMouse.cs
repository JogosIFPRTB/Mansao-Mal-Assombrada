using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class SeguirMouse : MonoBehaviour
{
    private Transform PosicaoMouse;
    void Update()
    {
        Vector3 PosicaoMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Pega o vector com rela��o a posi��o do mouse

        Vector3 direction = PosicaoMouse - transform.position;
        // "Remove" o transform possition para o objeto n�o siga o objeto e fique parado

        float angulo = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // Est� definindo o angulo como float, com o Mathf.Atan2 * Mathf.Rad2Deg ele calcula o angulo em radianos e delvolve em graus

        transform.rotation = Quaternion.Euler(0f, 0f, angulo);

    }
}