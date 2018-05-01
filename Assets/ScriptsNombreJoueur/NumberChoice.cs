using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;

public class NumberChoice : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnityEngine.UI.Button choix = GetComponent<UnityEngine.UI.Button>();
        choix.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel(1);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
