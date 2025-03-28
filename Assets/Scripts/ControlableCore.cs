using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class ControlableCore : MonoBehaviour
{
    public float speed = 100;


    public float jumpForce = 100;
    public float jumpCooldown = 0.1f;
    public float lastJumpTime = 0;
    public bool isGrounded = false;

    public bool freezeZRotation = true;

    private Rigidbody2D rb;

    private float defaultGravityScale;
    public float fallignGravityScale = 3;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (freezeZRotation) rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        defaultGravityScale = rb.gravityScale;
    }


    private void Update()
    {
        if (rb.linearVelocityY < 0)
        {
            rb.gravityScale = fallignGravityScale;
        }
        else
        {
            rb.gravityScale = defaultGravityScale;
        }
    }
}
