using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : Resource
{
    public Volcano(Planet parent, float angle)
    {
        this.planet = parent;
        this.angle = angle;
    }
}