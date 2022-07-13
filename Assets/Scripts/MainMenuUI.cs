using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuUI : MonoBehaviour
{

    [SerializeField]
    public TMP_InputField playerInputName;

    [SerializeField]
    public TMP_Text welcomePlayer;


    public string savedName;
    

    // Start is called before the first frame update
    void Start()
    {
        welcomePlayer.text = "Welcome " + GetPlayerName("PlayerName");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerInputName.text != null)
        {
            savedName = playerInputName.text;
            SetPlayerName("PlayerName", savedName);
        }
        else
        {
            GetPlayerName("PlayerName");
        }
              
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void AboutGame()
    {

    }

    public void SetPlayerName(string playerName , string name)
    {
        PlayerPrefs.SetString(playerName, name);
    }

    public string GetPlayerName(string playerName)
    {
        return PlayerPrefs.GetString(playerName);
    }
}
