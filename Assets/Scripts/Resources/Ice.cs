using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : Resource
{
    public Ice(Planet parent, int degree)
    {
        this.planet = parent;
        this.position = degree;
    }
}