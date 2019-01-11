using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCriterioScreen : MonoBehaviour {

    public int isCuantativo = 1;
    public GameObject ContainerCuantitativo;
    public GameObject ContainerCualitativo;

    public int CuantiValue;
    public int CualiValue;

    public string nameCriterio;

    public GameObject NewCriterioScreen;
    public GameObject btnAddCriterioScreen;

    public GameManager gameManager;

    /// <summary>
    /// seccion para crear un nuevo elemento teniendo la información recopilada
    /// </summary>
    public GameObject criterio;
    public Text criterioTextField;
    public GameObject parentElements;



    // Use this for initialization
    void Start () {
        SelectCuanti();
        CuantiValue = 0;
        CualiValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void SelectCuanti()
    {
        ContainerCuantitativo.SetActive(true);
        ContainerCualitativo.SetActive(false);
        isCuantativo = 1;
    }
    public void SelectCuantiValue(int value)
    {
        CualiValue = value;
    }



    public void SelectCuali()
    {
        ContainerCualitativo.SetActive(true);
        ContainerCuantitativo.SetActive(false);
        isCuantativo = 0;
    }
    public void SelectCualiValue(int value)
    {
        CualiValue = value;
    }


    public void addCriterio()
    {
        GameObject temp;
        temp = Instantiate(criterio, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        Criterio tempCriterio = temp.GetComponent<Criterio>();
        tempCriterio.refreshValue(criterioTextField.text, isCuantativo,CualiValue);
        NewCriterioScreen.SetActive(false);
        btnAddCriterioScreen.SetActive(true);
        gameManager.criterios.Add(tempCriterio);
    }

}
