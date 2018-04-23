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
        if (t > 2.0f) 
        {
            Debug.Log("Spawn");
            t = 0;
            for (int i = 0; i < 3; i++)
            {
                GameObject g = Instantiate(go);
                g.transform.position += new Vector3(0, i*50, 0);
            }
            
        }
    }
}
