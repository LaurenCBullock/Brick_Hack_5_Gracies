using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanHandler : MonoBehaviour {

    GameObject pan = new GameObject("pan_2");
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collision col)
    {
        col.transform.parent = pan.transform;
    }
}
