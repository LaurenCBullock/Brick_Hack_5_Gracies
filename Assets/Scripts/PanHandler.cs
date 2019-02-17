using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanHandler : MonoBehaviour {

	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("food")) {
            col.GetComponent<Rigidbody>().isKinematic = true;
            col.GetComponent<Rigidbody>().useGravity = false;
            col.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            col.GetComponent<MeshCollider>().isTrigger = true;
            col.transform.SetParent(GameObject.Find("pan_2").GetComponent<Transform>(), true);
        };
    }
}
