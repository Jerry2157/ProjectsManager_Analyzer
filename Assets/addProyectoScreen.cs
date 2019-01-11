using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addProyectoScreen : MonoBehaviour {

    public GameObject proyectoPrefab;
    public GameObject ProyectosContainer;

    public Text identificadorText;
    public Text nombreText;
    public Text costoText;

    public GameManager gameManager;

    // Use this for initialization
    void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}
    public void addProyecto()
    {
        GameObject temp;

        temp = Instantiate(proyectoPrefab, ProyectosContainer.transform.position, ProyectosContainer.transform.rotation) as GameObject;
        temp.transform.SetParent(ProyectosContainer.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        Proyecto tempProyecto = temp.GetComponent<Proyecto>();
        tempProyecto.RefreshValues(identificadorText.text,nombreText.text, int.Parse(costoText.text));
        gameManager.proyectos.Add(tempProyecto);
    }
}
