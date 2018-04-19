using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour {
    [SerializeField]
    Text health;
    [SerializeField]
    Text score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        health.text = "Life: " + GameControl.instance.Hp;
        score.text = "Score: " + GameControl.instance.Score;
	}
}
