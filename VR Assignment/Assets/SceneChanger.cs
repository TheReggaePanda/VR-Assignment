using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using static UnityEngine.Rendering.DebugUI;

public class SceneChanger : MonoBehaviour
{
    private int targetScore = 6;
    private int currentScore;
    ActionBasedControllerManager controllerManager;
    

    // Start is called before the first frame update
    void Start()
    {
        controllerManager = GameObject.Find("Complete XR Origin Set Up Variant").GetComponent<ActionBasedControllerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScore == targetScore)
        {
            Victory();
        }
    }

    private string sceneName;
    

    public void PlayGame()
    {
        
        SceneManager.LoadScene("Play Game");
    }
    public void GoToMenu()
    {

        SceneManager.LoadScene("Menu");
    }

    public void addScore()
    {
        currentScore++;
        Debug.Log(currentScore.ToString());
    }

    public void Victory()
    {
        SceneManager.LoadScene("Victory!");
    }

    
}
