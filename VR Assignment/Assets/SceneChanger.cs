using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string sceneName;
    public GameObject SettingsPanel;
    public GameObject MainMenuPanel;

    public void PlayGame()
    {
        
        SceneManager.LoadScene("Play Game");
    }

    public void GoToSettings()
    {
        
        SettingsPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }

    public void GoToMainMenu()
    {
        
        MainMenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
}
