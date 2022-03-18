using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : Resource
{
    public River(Planet parent, float angle)
    {
        this.planet = parent;
        this.angle = angle;
    }
}