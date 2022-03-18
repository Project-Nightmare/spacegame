using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : Resource
{
    public Forest(Planet parent, float angle)
    {
        this.planet = parent;
        this.angle = angle;
    }
}