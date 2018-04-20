using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {
    [SerializeField]
    GameObject teapot;
    [SerializeField]
    GameObject fireball;
    [SerializeField]
    GameObject doughnut;
    GameObject SelectedWeapon;
    string selectedwD;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SelectedWeapon = teapot;
            Debug.Log("teapot selected");
            selectedwD = "teapot";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            SelectedWeapon = doughnut;
            Debug.Log("doughnut selected");
            selectedwD = "doughnut";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SelectedWeapon = fireball;
            Debug.Log("fireball selected");
            selectedwD = "fireball";
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse is pressed");
            if(SelectedWeapon != null)
            {
               GameObject go = Instantiate(SelectedWeapon, new Vector3(transform.position.x, transform.position.y, transform.position.z),new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z,transform.rotation.w));
                go.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0 , 1000));
                Debug.Log("spawned: "+ selectedwD);
            }
        }
	}
}
