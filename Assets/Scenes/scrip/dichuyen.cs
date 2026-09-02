using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public float tocdo = 4f;

    private Rigidbody2D rb;
    private SpriteRenderer traiphai;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        traiphai = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Nhận phím trái/phải
        float input = Input.GetAxisRaw("Horizontal");

        // Di chuyển
        rb.linearVelocity = new Vector2(
            input * tocdo,
            rb.linearVelocity.y
        );

        // Quay mặt
        if (input > 0)
        {
            traiphai.flipX = false;
        }
        else if (input < 0)
        {
            traiphai.flipX = true;
        }
        //dieu khien animation
        animator.SetFloat("tocdo", Mathf.Abs(input));
    }
}