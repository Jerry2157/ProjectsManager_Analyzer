using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleColumController : MonoBehaviour {

    public Text textName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void setTittleCriterio(string name)
    {
        textName.text = name;
    }
}
