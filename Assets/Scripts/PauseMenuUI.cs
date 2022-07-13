using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenuUI : MonoBehaviour
{

    [SerializeField]
    private GameObject resumeGameButton;

    [SerializeField]
    private GameObject quitGameButton;

    [SerializeField]
    private GameObject mainMenuButton;

    private bool isPauseMenuActive = false;

    // Start is called before the first frame update
    void Start()
    {
        resumeGameButton.SetActive(false);
        quitGameButton.SetActive(false);
        mainMenuButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PauseMenuScreen();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseMenuScreen()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPauseMenuActive == false) 
        {
            Time.timeScale = 0;
            resumeGameButton.SetActive(true);
            quitGameButton.SetActive(true);
            mainMenuButton.SetActive(true);

            isPauseMenuActive = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPauseMenuActive == true) 
        {
            Time.timeScale = 1;
            resumeGameButton.SetActive(false);
            quitGameButton.SetActive(false);
            mainMenuButton.SetActive(false);
            isPauseMenuActive = false;

        }
    }

    public void ResumeGame() 
    {
        Time.timeScale = 1;
        resumeGameButton.SetActive(false);
        quitGameButton.SetActive(false);
        mainMenuButton.SetActive(false);
        isPauseMenuActive = false;
    }
}
