using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAsignValuesControllerResults : MonoBehaviour
{

    public List<GameObject> criterios = new List<GameObject>();
    public List<GameObject> proyectos = new List<GameObject>();
    public List<GameObject> values = new List<GameObject>();
    public List<GameObject> tupla = new List<GameObject>();


    public GameObject criterioObject;
    public GameObject parentElements;

    public AsigValuesSubtitlesControllerResults subtitlesController;

    public GameManager gameManager;

    public GameObject valueObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowPanelValues()
    {
        /*
        GetAllcriterios();
        GetAllproyectos();
        
        GetAllValues();
        for (int i = 0; i < criterios.Count; i++)
        {
            CreateTuplaCriterio(criterios[i], proyectos.Count, i);
        }
        for (int i = 0; i < proyectos.Count; i++)
        {
            string nameProyecto = proyectos[i].GetComponent<Proyecto>().identificador;
            subtitlesController.instantiateProjectsNames(nameProyecto);
        }*/

        SHowPanelValuesDirect();
    }

    public void SHowPanelValuesDirect(){
        GetAllValues();
        
        for (int i = 0; i < gameManager.criterios.Count; i++)
        {
            CreateTuplaCriterioDirect(gameManager.criterios[i], gameManager.proyectos.Count, i, gameManager.criterios[i].criterioPonderacion);
        }

        CreateTuplaCriterioDirectFoot(gameManager.criterios[0], gameManager.proyectos.Count, 0, gameManager.criterios[0].criterioPonderacion);
        CreateTuplaCriterioDirectFootTwo(gameManager.criterios[0], gameManager.proyectos.Count, 0, gameManager.criterios[0].criterioPonderacion);



        subtitlesController.instantiateProjectsNames("Ponderación");
        for (int i = 0; i < gameManager.proyectos.Count; i++)
        {
            string nameProyecto = gameManager.proyectos[i].identificador;
            subtitlesController.instantiateProjectsNames(nameProyecto);
        }

    }
    private void CreateTuplaCriterioDirect(Criterio criterio, int ProjectsTotal, int rowIndex, int ponderacion)
    {
        GameObject temp;
        temp = Instantiate(criterioObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        CriteriosProjectsValuesControllerResults temptupla = temp.GetComponent<CriteriosProjectsValuesControllerResults>();
        int isCuanti = criterio.isCuanti;
        string nameCriterio = criterio.criterioText;
        int isMaxBetter = criterio.value_CuanCuali;
        GetTuplaValues(rowIndex);
        temptupla.CreateProjectsNames(isCuanti, isMaxBetter, ProjectsTotal, nameCriterio, rowIndex, tupla, ponderacion);
        tupla.Clear();

    }

    private void CreateTuplaCriterioDirectFoot(Criterio criterio, int ProjectsTotal, int rowIndex, int ponderacion)
    {
        GameObject temp;
        temp = Instantiate(criterioObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        CriteriosProjectsValuesControllerResults temptupla = temp.GetComponent<CriteriosProjectsValuesControllerResults>();
        int isCuanti = criterio.isCuanti;
        string nameCriterio = criterio.criterioText;
        int isMaxBetter = criterio.value_CuanCuali;
        GetTuplaValues(rowIndex);
        temptupla.CreateProjectsNamesFoot(isCuanti, isMaxBetter, ProjectsTotal, nameCriterio, rowIndex, tupla, ponderacion);
        tupla.Clear();

    }

    private void CreateTuplaCriterioDirectFootTwo(Criterio criterio, int ProjectsTotal, int rowIndex, int ponderacion)
    {
        GameObject temp;
        temp = Instantiate(criterioObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        CriteriosProjectsValuesControllerResults temptupla = temp.GetComponent<CriteriosProjectsValuesControllerResults>();
        int isCuanti = criterio.isCuanti;
        string nameCriterio = criterio.criterioText;
        int isMaxBetter = criterio.value_CuanCuali;
        GetTuplaValues(rowIndex);
        temptupla.CreateProjectsNamesFootTwo(isCuanti, isMaxBetter, ProjectsTotal, nameCriterio, rowIndex, tupla, ponderacion);
        tupla.Clear();

    }



    private void CreateTuplaCriterio(GameObject criterio, int ProjectsTotal, int rowIndex)
    {
        GameObject temp;
        temp = Instantiate(criterioObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        CriteriosProjectsValuesControllerResults temptupla = temp.GetComponent<CriteriosProjectsValuesControllerResults>();
        int isCuanti = criterio.GetComponent<Criterio>().isCuanti;
        string nameCriterio = criterio.GetComponent<Criterio>().criterioText;
        int isMaxBetter = criterio.GetComponent<Criterio>().value_CuanCuali;
        //print("is Cuanti: " + isCuanti + ". isMaxBetter: "+isMaxBetter+". projectsTotal: "+ProjectsTotal + ". NameCriterio: "+nameCriterio);

        GetTuplaValues(rowIndex);
        
        //temptupla.CreateProjectsNames(isCuanti,isMaxBetter, ProjectsTotal, nameCriterio, rowIndex, tupla);
        tupla.Clear();
    }

    public void GetTuplaValues(int rowIndex)
    {
        foreach (GameObject go in values)
        {
            if (go.GetComponent<Value>().Row == rowIndex)
            {
                tupla.Add(go);
            }
        }
    }
    

    public void GetAllValues()
    {
        foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (go.tag == "Value")
            {
                values.Add(go);
            }
        }
    }

    public void GetAllcriterios()
    {
        foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (go.tag == "Criterio")
            {
                criterios.Add(go);
            }
        }
    }
    public void GetAllproyectos()
    {
        foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (go.tag == "Proyecto")
            {
                proyectos.Add(go);
            }
        }
    }
}
