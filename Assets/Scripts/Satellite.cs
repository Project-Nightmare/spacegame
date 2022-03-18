using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Satellite : WorldObject
{
    public WorldObject Parent { get; set; }
    public float OrbitalDistance = 2000;
    public float Speed = 30;

    void FixedUpdate()
    {
        Planet planet = (Planet)FindObjectOfType(typeof(Planet));
        this.Parent = planet;

        this.transform.RotateAround(Parent.transform.position, new Vector3(0, 0, 1), Speed / 100);
    }

    public Satellite(WorldObject Parent, float  OrbitalDistance)
    {
        this.Parent = Parent;
        this.OrbitalDistance = OrbitalDistance;
    }
}