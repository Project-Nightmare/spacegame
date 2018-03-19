using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : Resource
{
    public River(Planet parent, int degree)
    {
        this.planet = parent;
        this.position = degree;
    }
}