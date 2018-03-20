using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardToCamera : MonoBehaviour {

    public Camera cam;

    // Update is called once per frame
    void Update () {
        Quaternion camRot = cam.transform.rotation; // makes code easier to read

        transform.LookAt(transform.position + camRot * Vector3.forward, camRot * Vector3.up); // has the object billboard towards the camera
	}
}
