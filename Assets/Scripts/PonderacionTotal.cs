using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PonderacionTotal : MonoBehaviour {

    List<GameObject> goList = new List<GameObject>();
    string nameToAdd = "NumPonderacion";

    int total = 0;

    public Text text;

    // Use this for initialization
    void Start () {
        InvokeRepeating("GetAllPonderaciones", 0.5f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void GetAllPonderaciones()
    {

        text.text = " Total:" + total;
        total = 0;
        foreach (GameObject go in GameObject.FindObjectsOfType(typeof(GameObject)))
        {
            if (go.name == nameToAdd)
            {
                try
                {
                    total += int.Parse(go.GetComponent<Text>().text);
                }
                catch(System.Exception e)
                {
                    total = total;
                }
            }
        }
        
    }
}
