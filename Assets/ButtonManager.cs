using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void RunScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame() {
        Debug.Log("I quit!");
        Application.Quit();
    }
}
