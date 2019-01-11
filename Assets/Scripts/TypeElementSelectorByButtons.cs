using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeElementSelectorByButtons : MonoBehaviour {

    public Button btnCuantitativo;
    public Button btnCualitativo;
    public string stateType;

    public Color selectedColor;
    public Color unselectedColor;

    // Use this for initialization
    void Start () {
        ColorBlock cb = btnCuantitativo.colors;
        cb.normalColor = selectedColor;
        btnCuantitativo.colors = cb;

        ColorBlock cbTwo = btnCualitativo.colors;
        cbTwo.normalColor = selectedColor;
        btnCualitativo.colors = cbTwo;

        stateType = "cuantitativo";

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeType()
    {


        if (stateType == "cuantitativo")
        {
            ColorBlock cb = btnCuantitativo.colors;
            cb.normalColor = unselectedColor;
            btnCuantitativo.colors = cb;

            ColorBlock cbTwo = btnCualitativo.colors;
            cbTwo.normalColor = selectedColor;
            btnCualitativo.colors = cbTwo;

            stateType = "cualitativo";
        }
        else
        {
            ColorBlock cb = btnCuantitativo.colors;
            cb.normalColor = selectedColor;
            btnCuantitativo.colors = cb;

            ColorBlock cbTwo = btnCualitativo.colors;
            cbTwo.normalColor = unselectedColor;
            btnCualitativo.colors = cbTwo;
            stateType = "cuantitativo";
        }
    }
}
