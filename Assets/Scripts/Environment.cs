﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    [Range(0.0F, 100.0F)]
    public static float Gravity = 4.0F;

    public static float maxGravDist = 10000;

    private static WorldObject[] _WorldObjects;
    public static WorldObject[] WorldObjects
    {
        get
        {
            return _WorldObjects;
        }
    }

    // Use this for initialization
    void Start ()
    {

    }

    private void Awake()
    {
        _WorldObjects = GetWorldObjects();
    }

    private WorldObject[] GetWorldObjects()
    {
        return Resources.FindObjectsOfTypeAll<WorldObject>();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}