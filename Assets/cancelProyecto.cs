using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancelProyecto : MonoBehaviour {

    public GameObject panelAgregarProyecto;
    public GameObject btnAgregarProyecto;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cancelAddProyecto()
    {
        panelAgregarProyecto.SetActive(false);
        btnAgregarProyecto.SetActive(true);
    }
}
