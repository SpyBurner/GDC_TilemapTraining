using UnityEngine;

[RequireComponent (typeof(JoyStick), typeof(Rigidbody2D), typeof(ControlableCore))]
public class PlatformerMovement : MonoBehaviour
{
    private ControlableCore core;
    private Rigidbody2D rb;
    private JoyStick js;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        core = GetComponent<ControlableCore>();
        rb = GetComponent<Rigidbody2D>();
        js = GetComponent<JoyStick>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = js.getDirection();

        Walk(direction);
        Jump(direction);
    }

    void Walk(Vector2 direction)
    {
        print("Walking");
        rb.AddForce(new Vector2(direction.x * core.speed * Time.deltaTime, 0));
    }

    void Jump(Vector2 direction)
    {
        print("Jumping");
        if (core.isGrounded && direction.y > 0 && Time.time - core.lastJumpTime > core.jumpCooldown)
        {
            rb.AddForce(Vector2.up * core.jumpForce, ForceMode2D.Impulse);
            
            core.isGrounded = false;
            core.lastJumpTime = Time.time;
        }
    }
}
