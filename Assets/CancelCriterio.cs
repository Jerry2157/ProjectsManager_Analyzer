using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelCriterio : MonoBehaviour {

    public GameObject newCriterioScreen;
    public GameObject btnAddCriterio;

    public Text tittle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void returntoScreen()
    {
        tittle.text = "Establecimiento de criterios";
        newCriterioScreen.SetActive(false);
        btnAddCriterio.SetActive(true);
    }
}
