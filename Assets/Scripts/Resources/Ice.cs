using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : Resource
{
    public Ice(Planet parent, float angle)
    {
        this.planet = parent;
        this.angle = angle;
    }
}