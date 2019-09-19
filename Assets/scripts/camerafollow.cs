using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
    public Transform target;
    Vector3 camera;
	// Use this for initialization
	void Start () {
        camera = target.position;
        camera.z = -10;

	}
	
	// Update is called once per frame
	void Update () {
        camera = target.position;
        camera.z = -10;
        transform.position = camera;

    }
}
