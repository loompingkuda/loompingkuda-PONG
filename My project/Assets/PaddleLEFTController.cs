using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLEFTController : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //get input
        Vector2 movement = GetInput();
        MoveObject(movement);
    }
    public KeyCode upKey;
    public KeyCode downKey;

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    //move object
    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
}
