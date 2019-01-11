using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CriteriosProjectsValuesController : MonoBehaviour {

    public GameObject valueObject;
    public GameObject parentElements;

    public Text nameTextTupla;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateProjectsNames(int flagIsCuanti,int numProjects, string name, int RowIndex)
    {
        nameTextTupla.text = name;
        for (int i = 0; i < numProjects; i++)
        {
            instantiateProjectsNames(flagIsCuanti,RowIndex,i);
        }

    }
    public void instantiateProjectsNames(int flagIsCuanti,int RowIndex, int CoulumIndex)
    {
        GameObject temp;
        temp = Instantiate(valueObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        Value tempValue = temp.GetComponent<Value>();
        tempValue.setNewValue(flagIsCuanti,RowIndex,CoulumIndex);
    }
}
