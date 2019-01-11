using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueResults : MonoBehaviour
{

    public int Row;
    public int Colum;
    public int valuecell;
    public float valuecellFloat;

    public Text textvalue;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setNewValue (int RowIndex, int CoulumIndex, int value)
    {
        Row = RowIndex;
        Colum = CoulumIndex;
        valuecell = value;
        if(RowIndex == 100 && CoulumIndex == 100)
        {
            textvalue.text = "" + value + "%";
        }
        else
        {
            textvalue.text = "" + value;
        }
    }

    public void setNewValueFoot(int CoulumIndex,float value, int rowpassed, string name)
    {
        Row = rowpassed;
        Colum = CoulumIndex;
        if (name == "")
        {

            textvalue.text = "" + value;
        }
        else
        {

            textvalue.text = "" + name;
        }
        valuecellFloat = value;
    }
}
