using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Criterio : MonoBehaviour {

    public string criterioText;
    //public string criterioType;
    public int criterioPonderacion;

    public Text criterioTextUI;
    public Text criterioTypeUI;
    public InputField criterioPonderacionUI;

    public int isCuanti = 1;

    public int value_CuanCuali;

    public int flag;

    public void refreshValue(string criterio,int isCuantiPassed, int value_CuanCuali_Passed)
    {
        isCuanti = isCuantiPassed;
        value_CuanCuali = value_CuanCuali_Passed;
        criterioText = criterio;
        criterioTextUI.text = criterio;
        if (isCuanti == 1)
        {
            criterioTypeUI.text = "Cuantitativo";
        }
        else
        {
            criterioTypeUI.text = "Cualitativo";
        }
    }

	// Use this for initialization
	void Start () {
        
        if(flag == 1)
        {
            criterioTextUI.text = criterioText;
            if (isCuanti == 1)
            {
                criterioTypeUI.text = "Cuantitativo";
            }
            else
            {
                criterioTypeUI.text = "Cualitativo";
            }
        }
        
    }
	

	// Update is called once per frame
	void Update () {
		
	}
}
