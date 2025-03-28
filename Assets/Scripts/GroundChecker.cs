using UnityEngine;

[RequireComponent (typeof(ControlableCore))]
public class GroundChecker : MonoBehaviour
{
    public LayerMask whatIsGround;
    public float raycastLength = 5f;
    private ControlableCore core;
    void Start()
    {
        core = gameObject.GetComponent<ControlableCore>();
    }

    // Update is called once per frame
    void Update()
    {
        core.isGrounded = false;
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, Vector2.down, raycastLength, whatIsGround);

        if (hits.Length > 0)
        {
            core.isGrounded = true;
        }
    }
}
