using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAsignValuesController : MonoBehaviour {

    public List<GameObject> criterios = new List<GameObject>();
    public List<GameObject> proyectos = new List<GameObject>();


    public GameObject criterioObject;
    public GameObject parentElements;

    public AsigValuesSubtitlesController subtitlesController;

    public GameManager gameManager;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowPanelValues()
    {
        /*
        GetAllcriterios();
        GetAllproyectos();
        for(int i = 0; i < criterios.Count; i++)
        {
            CreateTuplaCriterio(criterios[i],proyectos.Count, i);
        }
        for(int i = 0; i< proyectos.Count; i++)
        {
            string nameProyecto = proyectos[i].GetComponent<Proyecto>().identificador;
            subtitlesController.instantiateProjectsNames(nameProyecto);
        }
        */
        SHowPanelValuesDirect();
    }

    public void SHowPanelValuesDirect()
    {
        //GetAllValues();

        for (int i = 0; i < gameManager.criterios.Count; i++)
        {
            CreateTuplaCriterioDirect(gameManager.criterios[i], gameManager.proyectos.Count, i);
        }
        for (int i = 0; i < gameManager.proyectos.Count; i++)
        {
            string nameProyecto = gameManager.proyectos[i].identificador;
            subtitlesController.instantiateProjectsNames(nameProyecto);
        }

    }
    private void CreateTuplaCriterioDirect(Criterio criterio, int ProjectsTotal, int rowIndex)
    {
        GameObject temp;
        temp = Instantiate(criterioObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        CriteriosProjectsValuesController temptupla = temp.GetComponent<CriteriosProjectsValuesController>();
        int isCuanti = criterio.isCuanti;
        string nameCriterio = criterio.criterioText;
        temptupla.CreateProjectsNames(isCuanti, ProjectsTotal, nameCriterio, rowIndex);

    }


    private void CreateTuplaCriterio(GameObject criterio, int ProjectsTotal, int rowIndex)
    {
        GameObject temp;
        temp = Instantiate(criterioObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        CriteriosProjectsValuesController temptupla = temp.GetComponent<CriteriosProjectsValuesController>();
        int isCuanti = criterio.GetComponent<Criterio>().isCuanti;
        string nameCriterio = criterio.GetComponent<Criterio>().criterioText;
        temptupla.CreateProjectsNames(isCuanti, ProjectsTotal, nameCriterio, rowIndex);
        
    }

    public void GetAllcriterios()
    {
        foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if(go.tag == "Criterio")
            {
                criterios.Add(go);
            }
        }
    }
    public void GetAllproyectos()
    {
        foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if(go.tag == "Proyecto")
            {
                proyectos.Add(go);
            }
        }
    }
}
