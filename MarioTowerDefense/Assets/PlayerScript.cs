using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    [SerializeField]
    GameObject[] towers;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Vector3 towerPos = towers[6].transform.position;
            transform.position = new Vector3(towerPos.x, towerPos.y, towerPos.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Vector3 towerPos = towers[5].transform.position;
            transform.position = new Vector3(towerPos.x, towerPos.y, towerPos.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Vector3 towerPos = towers[4].transform.position;
            transform.position = new Vector3(towerPos.x, towerPos.y, towerPos.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Vector3 towerPos = towers[3].transform.position;
            transform.position = new Vector3(towerPos.x, towerPos.y, towerPos.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Vector3 towerPos = towers[2].transform.position;
            transform.position = new Vector3(towerPos.x, towerPos.y, towerPos.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Vector3 towerPos = towers[1].transform.position;
            transform.position = new Vector3(towerPos.x, towerPos.y, towerPos.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Vector3 towerPos = towers[0].transform.position;
            transform.position = new Vector3(towerPos.x, towerPos.y, towerPos.z);
        }
    }
}
