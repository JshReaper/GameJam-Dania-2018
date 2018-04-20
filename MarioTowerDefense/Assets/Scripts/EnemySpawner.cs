using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawner : MonoBehaviour {
    
    [SerializeField]
    GameObject go;
    // Use this for initialization
    float t = 0;

    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        t  += Time.deltaTime;
        if (t > 5) 
        {
            Debug.Log("Spawn");
            t = 0;
            Instantiate(go);
            
        }
        Debug.Log(t);
    }
}
