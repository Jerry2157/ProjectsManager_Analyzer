using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddProyecto : MonoBehaviour {

    public GameObject panelAgregarProyecto;

    public GameObject panelCriterios;
    public GameObject panelNewCriterio;
    public GameObject buttonNewCriterio;
    public GameObject buttonAsignarValores;
    public GameObject buttonAddProject;
    
    public GameObject total;

    public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void agregarProyecto()
    {
        panelAgregarProyecto.SetActive(true);
        panelCriterios.SetActive(false);
        panelNewCriterio.SetActive(false);
        buttonNewCriterio.SetActive(false);
        buttonAsignarValores.SetActive(true);
        buttonAddProject.SetActive(false);
        total.SetActive(false);
        text.text = "Registro de proyectos";
    }
}
