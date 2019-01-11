using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour {

    public int Row;
    public int Colum;

    public GameObject Cuantitativo;
    public GameObject Cualitativo;

    public Text valueCuantiText;
    public Dropdown dropdownCuali;

    public int isCuantiFlag;

    public int CuantiValue = 0;
    public int CualiValue = 0;

    public int valueNum;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SetMainValue", 0.2f, 0.2f);
        InvokeRepeating("onIndexChanged", 0.2f, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetMainValue()
    {
        int.TryParse(valueCuantiText.text, out valueNum);
    }

    public void setNewValue(int flagIsCuanti, int RowIndex, int CoulumIndex)
    {
        Row = RowIndex;
        Colum = CoulumIndex;
        isCuantiFlag = flagIsCuanti;
        if(flagIsCuanti == 1)
        {
            Cuantitativo.SetActive(true);
            Cualitativo.SetActive(false);
        }
        else
        {
            Cuantitativo.SetActive(false);
            Cualitativo.SetActive(true);
        }

    }

    public void onIndexChanged()
    {
        if(isCuantiFlag == 0){

            valueNum = dropdownCuali.value;
        }
    }
}
