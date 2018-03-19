using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : WorldObject
{
    [Range(0.0F, 10.0F)]
    public float MoveSpeed;

    private void Start()
    {

    }

    private void Awake()
    {

    }

    private void Update()
    {
        Movement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {

    }

    private void Gather()
    {

    }

    private void UseItem()
    {

    }

    private void Jump()
    {

    }



    private void Movement(float InputX, float InputY)
    {
        InputX *= Time.deltaTime * MoveSpeed;
        InputY *= Time.deltaTime * MoveSpeed;

        this.body.AddForce((Vector2)this.transform.position + new Vector2(InputX, InputY));

       // transform.Rotate(InputX, (InputY * -1), 0, 0);
    }
}
