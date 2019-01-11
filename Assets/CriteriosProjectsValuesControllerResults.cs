using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CriteriosProjectsValuesControllerResults : MonoBehaviour
{

    public GameObject valueObject;
    public GameObject parentElements;

    public Text nameTextTupla;

    public List<GameObject> values = new List<GameObject>();
    public List<GameObject> coulumtemp = new List<GameObject>();

    GameObject tempObject;
    int tempValuePerValueBox = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateProjectsNames(int flagIsCuanti,int isMaxBetter, int numProjects, string name, int RowIndex, List<GameObject> tupla, int ponderacion)
    {
        instantiateProjectsNames(ponderacion, 100, 100);
        nameTextTupla.text = name;
        print("----------------------------------------------------------------");
        int j = 0;
        //print("tuplas count: " + tupla.Count);
        for (int i = 0; i < numProjects; i++)
        {
            foreach (GameObject go in tupla)
            {
                if (go.GetComponent<Value>().Colum == i)
                {
                    //print("i got the tempobject");
                    tempObject = go;
                    //print("tempValue: " + tempObject.GetComponent<Value>().valueNum);
                    //print("obtuve un tempObject");
                }
            }

            if (isMaxBetter >= 1){
                print("--------");
                foreach (GameObject go in tupla)
                {
                    j += 1;
                    //print("j: " + j);

                    //print("is Max better: 1, valuetemp: " + tempObject.GetComponent<Value>().valueNum + ". Every Row Value: " + go.GetComponent<Value>().valueNum);
                    //print("a: " + tempObject.GetComponent<Value>().valueNum + ". b :" + go.GetComponent<Value>().valueNum);
                    if (tempObject.GetComponent<Value>().valueNum>= go.GetComponent<Value>().valueNum && tempObject.GetComponent<Value>().valueNum != go.GetComponent<Value>().valueNum)
                    {
                        tempValuePerValueBox += 2;
                    }
                }
                print("--------");
            }
            else
            {
                //tempValuePerValueBox = (2*(numProjects))-1;
                foreach (GameObject go in tupla)
                {
                    j += 1;
                    //print("j: " + j);
                    //sprint("is Max better: 0, valuetemp: " + tempObject.GetComponent<Value>().valueNum + ". Every Row Value: " + go.GetComponent<Value>().valueNum);
                    if (tempObject.GetComponent<Value>().valueNum <= go.GetComponent<Value>().valueNum && tempObject.GetComponent<Value>().valueNum != go.GetComponent<Value>().valueNum)
                    {
                        tempValuePerValueBox += 2;
                    }
                }
            }
            
            instantiateProjectsNames(tempValuePerValueBox, RowIndex, i);
            tempValuePerValueBox = 1;
        }
    }




    public void CreateProjectsNamesFoot(int flagIsCuanti, int isMaxBetter, int numProjects, string name, int RowIndex, List<GameObject> tupla, int ponderacion)
    {
        GetAllValues();
        instantiateProjectsNamesFoot(0, 100,100,"");
        nameTextTupla.text = "";
        print("----------------------------------------------------------------");
        
        //print("tuplas count: " + tupla.Count);
        for (int i = 0; i < numProjects; i++)
        {
            foreach (GameObject go in values)
            {
                if (go.GetComponent<ValueResults>().Colum == i)
                {
                    coulumtemp.Add(go);
                }
            }
            float tempSum = 0;
            float j = 0;
            foreach(GameObject go in coulumtemp)
            {
                tempSum += go.GetComponent<ValueResults>().valuecell;
                j += 1;
            }
            tempSum = tempSum / j;
            coulumtemp.Clear();
            instantiateProjectsNamesFoot(i, tempSum,1000,"");
            
        }
    }

    public void CreateProjectsNamesFootTwo(int flagIsCuanti, int isMaxBetter, int numProjects, string name, int RowIndex, List<GameObject> tupla, int ponderacion)
    {
        GetAllValues();
        instantiateProjectsNamesFoot(0, 100,100, "Prioridad");
        nameTextTupla.text = "";
        //print("----------------------------------------------------------------");
        
        //print("tuplas count: " + tupla.Count);
        for (int i = 0; i < numProjects; i++)
        {
            foreach (GameObject go in values)
            {
                if (go.GetComponent<ValueResults>().Row == 1000)
                {
                    coulumtemp.Add(go);
                }
            }
            ValueResults tempValueResults;
            float tempNum = 0;
            float tempPriority = 1;
            //print("total in coulumtemp: " + coulumtemp.Count);
            foreach (GameObject go in coulumtemp)
            {
                if(go.GetComponent<ValueResults>().Colum == i)
                {
                    tempValueResults = go.GetComponent<ValueResults>();
                    tempNum = tempValueResults.GetComponent<ValueResults>().valuecellFloat;
                    //print("temp: " + tempNum);
                }
            }
            for (int j = 0; j < coulumtemp.Count; j++)
            {
                //print("temp: " + tempNum + ". valuecell:" + coulumtemp[j].GetComponent<ValueResults>().valuecellFloat);
                if (coulumtemp[j].GetComponent<ValueResults>().valuecellFloat > tempNum)
                {
                    tempPriority += 1;
                }
            }
            coulumtemp.Clear();
            instantiateProjectsNamesFoot(i, tempPriority, 1001, "");

        }
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

    public void instantiateProjectsNamesFoot( int CoulumIndex, float valueNum, int row, string name)
    {
        GameObject temp;
        temp = Instantiate(valueObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        ValueResults tempValue = temp.GetComponent<ValueResults>();
        tempValue.setNewValueFoot(CoulumIndex, valueNum, row, name);
    }

    public void instantiateProjectsNames(int valueNum, int RowIndex, int CoulumIndex)
    {
        GameObject temp;
        temp = Instantiate(valueObject, parentElements.transform.position, parentElements.transform.rotation) as GameObject;
        temp.transform.SetParent(parentElements.transform);
        temp.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        ValueResults tempValue = temp.GetComponent<ValueResults>();
        tempValue.setNewValue(RowIndex, CoulumIndex, valueNum);
    }
}