﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : SuperPowerBase {

    public Wall(GameObject owner) : base(owner)
    {

    }
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    override public void Update()
    {
        base.Update();
    }


    override protected void TriggerEffect()
    {

    }

    override protected void CleanUp()
    {
        base.CleanUp();
    }
}