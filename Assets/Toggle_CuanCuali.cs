using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Toggle_CuanCuali : MonoBehaviour {

    ToggleGroup toggleGroupInstance;

    public Toggle currentSelection
    {
        get
        {
            return toggleGroupInstance.ActiveToggles().FirstOrDefault();
        }
    }

	// Use this for initialization
	void Start () {
        toggleGroupInstance = GetComponent<ToggleGroup>();
        //print("First selected: " + currentSelection.name);
        //SelectToggle(2);
	}
	
    public void SelectToggle(int id)
    {
        Toggle toggles = toggleGroupInstance.GetComponentInChildren<Toggle>();
        //toggles. = true;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
