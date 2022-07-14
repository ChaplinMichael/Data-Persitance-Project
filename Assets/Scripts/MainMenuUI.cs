using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;

public class MainMenuUI : MonoBehaviour
{
    

    [SerializeField]
    public TMP_InputField playerInputName;

    [SerializeField]
    public TMP_Text welcomePlayer;


    public string playerName;

    private void Awake()
    {
        LoadPlayerData();
    }


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
              
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
    public void GetInputText()
    {
        playerName = playerInputName.text.ToString();
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
    }

    public void SavePlayerData() 
    {
        SaveData data = new SaveData();
        playerName = playerInputName.text.ToString();
        data.playerName = playerName;
        string jsonData = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/saveData.json", jsonData);
    }

    public void LoadPlayerData() 
    {
        string path = Application.persistentDataPath + "/saveData.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            playerInputName.text = playerName;
            welcomePlayer.text = "Welcome " + playerName;
        }
    }

    
}
