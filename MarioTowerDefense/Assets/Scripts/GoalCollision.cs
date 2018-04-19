using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour {
    int life;
    // Use this for initialization
    void Start () {
        life = 3;
	}
	
	// Update is called once per frame
	void Update () {
        if (life == 0)
        {
            Application.Quit();
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            life--;
        }
    }
}
