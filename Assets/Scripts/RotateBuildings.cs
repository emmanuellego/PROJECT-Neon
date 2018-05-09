using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBuildings : MonoBehaviour {

    public float spd = 15.0f;

	void Update () {
        transform.Rotate(Vector3.up, spd * Time.deltaTime);
    }
}
