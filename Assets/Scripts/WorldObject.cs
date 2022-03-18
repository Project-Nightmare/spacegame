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

        //turn on for real gravity
        //Attract();
    }

    public void Attract()
    {
        foreach (WorldObject WorldObject in Environment.WorldObjects)
        {
            if (WorldObject != this)
            {
                Vector2 posDifference = (this.transform.position - WorldObject.transform.position);

                float distance = Vector2.Distance(this.transform.position, WorldObject.transform.position);

                //this.body.AddForce(v.normalized * (1.0f - dist / Environment.maxGravDist) * Environment.Gravity);

                WorldObject.body.AddForce((Environment.Gravity * this.body.mass / distance / 100) * posDifference.normalized);
            }
        }
    }
}
