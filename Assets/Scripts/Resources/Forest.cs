using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : Resource
{
    public Forest(Planet parent, int degree)
    {
        this.planet = parent;
        this.position = degree;
    }
}