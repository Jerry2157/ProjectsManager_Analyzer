using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipoElementSelector : MonoBehaviour {

    public Toggle toggleCuantitativo;
    public Toggle toggleCualitativo;

    public string stateType;

    // Use this for initialization
    void Start () {
        toggleCuantitativo.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggleCuantitativo);
        });
        toggleCualitativo.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggleCualitativo);
        });
        stateType = "cuantitativo";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeType()
    {
        if (stateType == "cuantitativo")
        {
            stateType = "cualitativo";
        }
        else
        {
            stateType = "cuantitativo";
        }
    }

    void ToggleValueChanged(Toggle change)
    {
        if (stateType == "cuantitativo")
        {
            stateType = "cualitativo";
        }
        else
        {
            stateType = "cuantitativo";
        }
    }
}
