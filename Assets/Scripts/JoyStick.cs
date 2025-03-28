using System;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    private Vector2 direction = Vector2.one;
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction.x = direction.y = 0;
        //Debug.Log(Input.anyKey);
        if (Input.anyKey)
        {
            //Debug.Log("Some key pressed");
            direction.x = (Input.GetKey(left) ? -1 : 0) + (Input.GetKey(right) ? 1 : 0);
            direction.y = (Input.GetKey(up) ? 1 : 0) + (Input.GetKey(down) ? -1 : 0);
        }
    }

    public Vector2 getDirection()
    {
        return direction;
    }
}
