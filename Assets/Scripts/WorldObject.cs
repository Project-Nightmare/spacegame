using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D body;
    public Collider2D collider;

    // Use this for initialization
    void Start ()
    {
    }

    private void Awake()
    {
        //body = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {

	}

    private void FixedUpdate()
    {
        Attract();
    }

    public void Attract()
    {
        foreach (WorldObject WorldObject in Environment.WorldObjects)
        {
            if (WorldObject != this && !WorldObject.collider.IsTouching(this.collider));
            {
                Vector2 posDifference = (this.transform.position - WorldObject.transform.position);

                WorldObject.body.AddForce(Environment.Gravity * posDifference.normalized);
            }
        }
    }
}
