﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            GameControl.instance.Score += 100;
            Destroy(gameObject);
        }

    }
}