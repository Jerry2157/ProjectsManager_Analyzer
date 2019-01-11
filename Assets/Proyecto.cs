using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Proyecto : MonoBehaviour {

    public string identificador;
    public string nombre;
    public int costo;

    public Text nombreText;
    public Text costoText;

    public int flag;

    public GameManager gameManager;

    public void RefreshValues(string identificador_passed, string nombre_passed, int costo_passed)
    {
        identificador = identificador_passed;
        nombre = nombre_passed;
        costo = costo_passed;

        nombreText.text = "Proyecto " + identificador;
        costoText.text = "$ " + costo;

    }

	// Use this for initialization
	void Start () {
        if (flag == 1)
        {
            nombreText.text = "" + nombre;
            costoText.text = "$ " + costo;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
