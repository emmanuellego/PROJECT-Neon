using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("I quit!");
            Application.Quit();
        }
    }
}
