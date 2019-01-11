using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowResult : MonoBehaviour {


    public GameObject PanelFinal;
    public GameObject[] botones;

    public GameObject myselfButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showpanelfinal()
    {
        PanelFinal.SetActive(true);
        myselfButton.SetActive(false);
        PanelFinal.GetComponent<AddProyectosScreenFinal>().CreateFinalProjects();
        for(int i = 0; i < botones.Length; i++){
            botones[i].SetActive(false);
        }
    }
}
