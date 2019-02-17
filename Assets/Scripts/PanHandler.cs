using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanHandler : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "food")
        {
            col.transform.parent = this.transform;
        }
    }
}
