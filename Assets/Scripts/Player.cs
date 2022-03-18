using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : WorldObject
{
    [Range(0.0F, 10.0F)]
    public float Speed;

    [Range(0.1F, 10.0F)]
    public float MaxSpeed;

    float rotationSpeed = 1.0F;
    private Vector3 velocity = Vector3.zero;

    private Vector3 targetPosition;


    public bool grounded;

    private void Start()
    {
        
    }

    private void Draw()
    {
        List<Vector2> _vertices = new List<Vector2>(3);
    }

    private void Awake()
    {

    }

    private void Update()
    {
        Movement();
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

    private void Movement()
    {
        var a = Input.GetKeyDown("a");
        var d = Input.GetKeyDown("d");
        var w = Input.GetKeyDown("w");
        var s = Input.GetKeyDown("s");

        if (a && !d)
        {
            this.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        else if (d && !a)
        {
            transform.Rotate(Vector3.forward * 90);
        }

        if (w && !s)
        {
            transform.Rotate(Vector3.forward * -90);
        }
        else if (s && !w)
        {

        }


        if (Input.GetKey("a"))
        {
            var pos = Input.mousePosition;

            var targetRotation = Quaternion.LookRotation(pos - transform.position);
            velocity += transform.forward * Time.deltaTime;
        }

    }
}
