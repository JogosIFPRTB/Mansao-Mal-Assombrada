using UnityEngine;

public class Movimentação : MonoBehaviour
{
    public float Speed;

    private Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rb.linearVelocity = direction.normalized * Speed;

        if (direction.x != 0)
        {
            anim.SetLayerWeight(0, 0);
            anim.SetLayerWeight(2, 1);

            if (direction.x < 0)
            {
                sprite.flipX = false;
            } else
            {
                sprite.flipX = true;
            }
        }

        if (direction != Vector2.zero)
        {
            anim.SetBool("walking", false);
        } else
        {
            anim.SetBool("walking", true);
        }
    }
}
