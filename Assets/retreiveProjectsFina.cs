using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class retreiveProjectsFina : MonoBehaviour {

    public Text presupuesto;
    public Text proyectospanel;
    public GameManager gameManager;

    public int remainingsum = 0;
    public string proyectsAdmited = "";

	// Use this for initialization
	void Start () {
        InvokeRepeating("refreshadmitedprojects", 0.2f, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void refreshadmitedprojects()
    {
        proyectsAdmited = "";
        int.TryParse(presupuesto.text, out remainingsum);
        foreach(ProyectoFinal go in gameManager.proyectosFinal)
        {
            if (remainingsum >=go.costo)
            {
                remainingsum -= go.costo;
                proyectsAdmited = proyectsAdmited + go.nombre + "\r\n";
                

            }
        }
        proyectospanel.text = proyectsAdmited;
    }

}
