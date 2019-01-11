using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddProyectosScreenFinal : MonoBehaviour
{

    public GameObject proyectoPrefab;
    public GameObject ProyectosContainer;

    public Text identificadorText;
    public Text nombreText;
    public Text costoText;

    public GameManager gameManager;


    public List<GameObject> values = new List<GameObject>();
    public List<GameObject> coulumtemp = new List<GameObject>();

    public int tempPro = 0;
    public int k = 0;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void CreateFinalProjects()
    {
        GetAllValues();
        for (int i = 0; i < gameManager.proyectos.Count; i++)
        {
            foreach (GameObject go in values)
            {
                if (go.GetComponent<ValueResults>().Row == 1001)
                {
                    coulumtemp.Add(go);
                }
            }
            ValueResults tempValueResults;
            tempPro = 0;
            foreach (GameObject go in coulumtemp)
            {
                print("i: "+ (gameManager.proyectos.Count - i) +". valuecolum: " + go.GetComponent<ValueResults>().valuecellFloat);
                if (go.GetComponent<ValueResults>().valuecellFloat == (gameManager.proyectos.Count - i))
                {
                    tempValueResults = go.GetComponent<ValueResults>();
                    tempPro = (gameManager.proyectos.Count - i);
                }
            }
            print("--------------------------------------");
            coulumtemp.Clear();
            addProyecto(tempPro, i+1);
        }

    }

    public void addProyecto(int project, int index)
    {
        GameObject temp;

        temp = Instantiate(proyectoPrefab, ProyectosContainer.transform.position, ProyectosContainer.transform.rotation) as GameObject;
        temp.transform.SetParent(ProyectosContainer.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        ProyectoFinal tempProyecto = temp.GetComponent<ProyectoFinal>();
        int tempNum = 0;
        //int.TryParse(gameManager.proyectos[project].costoText.text, out tempNum);
        tempProyecto.RefreshValues(""+index, gameManager.proyectos[project-1].nombreText.text, gameManager.proyectos[project-1].costo,tempPro);
        gameManager.proyectosFinal.Add(tempProyecto);
        
    }

    public void GetAllValues()
    {
        foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (go.tag == "ValueResult")
            {
                values.Add(go);
            }
        }
    }
}
