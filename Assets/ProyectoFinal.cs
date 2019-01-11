using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProyectoFinal : MonoBehaviour
{

    public string identificador;
    public string nombre;
    public int costo;

    public Text nombreText;
    public Text costoText;
    public Text ID;

    public int flag;

    public GameManager gameManager;

    int posOccupied;

    public void RefreshValues(string identificador_passed, string nombre_passed, int costo_passed, int posOccupiedPassed)
    {
        identificador = identificador_passed;
        nombre = nombre_passed;
        costo = costo_passed;

        nombreText.text = "Proyecto " + identificador;
        costoText.text = "$ " + costo;
        ID.text = identificador_passed;
        posOccupied = posOccupiedPassed;
    }

    // Use this for initialization
    void Start()
    {
        if (flag == 1)
        {
            nombreText.text = "" + nombre;
            costoText.text = "$ " + costo;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
