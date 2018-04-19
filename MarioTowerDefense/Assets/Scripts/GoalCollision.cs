using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (GameControl.instance.Hp == 0)
        {
            Application.Quit();
        }
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameControl.instance.Hp--;
            Destroy(other.gameObject);
        }
    }
}
