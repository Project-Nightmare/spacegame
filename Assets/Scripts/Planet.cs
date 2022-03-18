using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : WorldObject
{
    [SerializeField]
    int numberOfResources = 4;

    [SerializeField]
    int numberofSatellites = 1;

    public List<Resource> Resources = new List<Resource>();
    public List<Satellite> Satellites = new List<Satellite>();

    // Use this for initialization
    void Start ()
    {
        Satellite moon = (Satellite)FindObjectOfType(typeof(Satellite));
        this.Satellites.Add(moon);

        CreateResources();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void CreateResources()
    {
        int spacing = (int)Math.Round((360.00 / numberOfResources), 0);

        System.Random random = new System.Random() { };

        for (int n = 0; n < numberOfResources; n++)
        {
            var angle = n * Mathf.PI * 2 / numberOfResources;
            CreateResource(random.Next(0, 3), angle);
            angle += spacing;
        }
    }

    private void CreateResource(int resource, float angle)
    {
        var pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * ((CircleCollider2D)this.collider).radius;

        switch (resource)
        {
            case 0:
                {

                    this.Resources.Add(new Volcano(this, angle));
                    break;
                }
            case 1:
                {
                    this.Resources.Add(new Ice(this, angle));
                    break;
                }
            case 2:
                {
                    this.Resources.Add(new Forest(this, angle));
                    break;
                }
            case 3:
                {
                    this.Resources.Add(new River(this, angle));
                    break;
                }
        }
    }
}