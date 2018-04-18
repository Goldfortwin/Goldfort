using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;

public class AccueilControl : MonoBehaviour {
    //public UnityEngine.UI.Button newGame;
    // Use this for initialization
    void Start () {
        UnityEngine.UI.Button newGame = GetComponent<UnityEngine.UI.Button>();
        newGame.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel(2);

    }

	// Update is called once per frame
	void Update () {
    
	}
}
