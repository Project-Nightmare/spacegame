using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour
{
    [Range(0.0F, 10000.0F)]
    public float Mass;

    private Rigidbody2D _Body;
    public Rigidbody2D Body
    {
        get
        {
            return _Body;
        }
    }

    // Use this for initialization
    void Start ()
    {
    }

    private void Awake()
    {
        _Body = this.GetComponent<Rigidbody2D>();
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
            Vector2 Distance = (this.transform.position - WorldObject.transform.position);

            if (Distance.normalized.sqrMagnitude > 0.0F)
            {
                float GravitationalPull = (Environment.Gravity * (this.Mass * WorldObject.Mass)) / (Distance.sqrMagnitude);

                this.Body.AddForce(GravitationalPull * Distance, ForceMode2D.Impulse);
            }
        }
    }
}
