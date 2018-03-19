using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : Resource
{
    public Volcano(Planet parent, int degree)
    {
        this.planet = parent;
        this.position = degree;
    }
}