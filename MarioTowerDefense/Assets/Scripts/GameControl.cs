using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    public static GameControl instance;
    public int Score { get; set; }

    public int Hp { get; set; }
   
    // Use this for initialization
    void Start () {
		if(instance == null)
        {
            Hp = 3;
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
