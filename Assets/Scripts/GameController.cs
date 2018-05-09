using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject commandPanel, pausePanel; // Panels for game behavior

    private bool isPaused = false, isCommandPanelOpen = false;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused) 
            PauseGame();
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused) 
            PauseGame();

        if (Input.GetMouseButtonDown(1) && !IsCommandPanelActive()) {
            commandPanel.SetActive(true);
            isCommandPanelOpen = true;
        }
        else if (Input.GetMouseButtonDown(1) && IsCommandPanelActive()) {
            GameObject[] menus = GameObject.FindGameObjectsWithTag("Menu");
            foreach (GameObject menu in menus)
                menu.SetActive(false);
            isCommandPanelOpen = false;
        }
	}

    bool IsCommandPanelActive() {
        if (commandPanel.activeInHierarchy || isCommandPanelOpen)
            return true;
        else if (!commandPanel.activeInHierarchy && !isCommandPanelOpen)
            return false;
        return false;
    }

    public void CommandPanelState() {
        if (isCommandPanelOpen) {
            isCommandPanelOpen = false;
            return;
        }
        isCommandPanelOpen = true;
    }

    public void PauseGame() {
        if (!isPaused) {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }

        else {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
    }

    public void RunScene(string scene) {
        SceneManager.LoadScene(scene);
    }

}
