using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour {
    Camera cam;
    public bool rotate;
	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        cam.fieldOfView = 60f;
    }
	
	// Update is called once per frame
	void Update () {
        if(rotate)
        {
            transform.rotation = new Quaternion (transform.parent.rotation.x * -1f, transform.parent.rotation.y * -1f, transform.parent.rotation.z * -1f, transform.parent.rotation.w ) ;

        }
        cam.fieldOfView = 179f;
    }
}
