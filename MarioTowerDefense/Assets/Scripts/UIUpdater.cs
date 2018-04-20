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
        if (GameControl.instance != null)
        { 
        GameControl.instance.Hp = 3;
        GameControl.instance.Score = 0;
        }

    }

    // Update is called once per frame
    void Update () {
        if (GameControl.instance != null) { 
            health.text = "Life: " + GameControl.instance.Hp;
        score.text = "Score: " + GameControl.instance.Score;
        }
    }
}
