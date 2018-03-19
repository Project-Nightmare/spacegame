using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : WorldObject
{
    [SerializeField]
    int numberOfResources;

    public List<Resource> Resources = new List<Resource>(); 

	// Use this for initialization
	void Start ()
    {
        CreateResources();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void CreateResources()
    {
        int degree = 0;
        int spacing = (int)Math.Round((360.00 / numberOfResources), 0);

        System.Random random = new System.Random() { };

        for (int n = 0; n < numberOfResources; n++)
        {
            CreateResource(random.Next(0, 3), degree);
            degree += spacing;
        }
    }

    private void CreateResource(int resource, int degree)
    {
        switch (resource)
        {
            case 0:
                {
                    this.Resources.Add(new Volcano(this, degree));
                    break;
                }
            case 1:
                {
                    this.Resources.Add(new Ice(this, degree));
                    break;
                }
            case 2:
                {
                    this.Resources.Add(new Forest(this, degree));
                    break;
                }
            case 3:
                {
                    this.Resources.Add(new River(this, degree));
                    break;
                }
        }
    }
}