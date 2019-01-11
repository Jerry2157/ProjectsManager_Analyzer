using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCriterio : MonoBehaviour {

    public GameObject criterio;

    public GameObject parentElements;

    public GameObject newCriterioScreen;
    public GameObject btnNewCriterios;

    public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void addCriterioTest()
    {
        //GameObject temp;
        //temp = Instantiate(criterio, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        //temp.transform.SetParent(parentElements.transform);

        newCriterioScreen.SetActive(true);
        btnNewCriterios.SetActive(false);
        text.text = "Nuevo Criterio";
    }
}
