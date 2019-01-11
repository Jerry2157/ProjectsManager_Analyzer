using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsigValuesSubtitlesControllerResults : MonoBehaviour
{

    public GameObject subtitleObject;
    public GameObject parentElements;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateProjectsNames(int numCriterios, string[] projectsNames)
    {
        GameObject temp;
        temp = Instantiate(subtitleObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        SubtitleColumController tempCriterio = temp.GetComponent<SubtitleColumController>();
        tempCriterio.setTittleCriterio("ponderación");
        for (int i = 0; i < numCriterios; i++)
        {
            instantiateProjectsNames(projectsNames[i]);
        }

    }
    public void instantiateProjectsNames(string name)
    {
        GameObject temp;
        temp = Instantiate(subtitleObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        SubtitleColumController tempCriterio = temp.GetComponent<SubtitleColumController>();
        tempCriterio.setTittleCriterio(name);
    }
}
