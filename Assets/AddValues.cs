using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddValues : MonoBehaviour {
    public GameObject panelAgregarValores;
    public GameObject buttonAgregarProyectos;
    public GameObject buttonAsignarValores;
    public GameObject buttonMostrarMatriz;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void agregarProyecto()
    {
        panelAgregarValores.SetActive(true);
        panelAgregarValores.GetComponent<PanelAsignValuesController>().ShowPanelValues();
        buttonAgregarProyectos.SetActive(false);
        buttonAsignarValores.SetActive(true);
    }
    public void agregarProyectoResults()
    {
        panelAgregarValores.SetActive(true);
        panelAgregarValores.GetComponent<PanelAsignValuesControllerResults>().ShowPanelValues();
        buttonAsignarValores.SetActive(false);
        buttonMostrarMatriz.SetActive(true);
    }
}
