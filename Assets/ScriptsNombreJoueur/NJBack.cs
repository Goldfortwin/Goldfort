using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;

public class NJBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnityEngine.UI.Button retour = GetComponent<UnityEngine.UI.Button>();
        retour.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel(0);

    }
    // Update is called once per frame
    void Update () {
		
	}
}
