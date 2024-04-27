using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectionPoint : MonoBehaviour
{
    GameManager gameManager;

    public int WoodMax;
    public int StoneMax;
    private int WoodCount;
    private int StoneCount;
    public GameObject Button;
    public GameObject Building;
    public TextMeshProUGUI Woodtext;
    public TextMeshProUGUI Stonetext;
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        WoodCount = WoodMax;
        StoneCount = StoneMax;

        TextUpdate();
    }

   
    // Update is called once per frame
    void Update()
    {
        TextUpdate();

        if(WoodMax <= gameManager.Wood() && StoneMax <= gameManager.Stone())
        {
            Build();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wood")
        {
            gameManager.WoodCountUp();
            WoodCount--;
        }
        if (other.gameObject.tag == "Stone")
        {
            gameManager.StoneCountUp();
            StoneCount--;
        }
        if (other.gameObject.tag == "BigStone")
        {
            gameManager.StoneCountUp();
            gameManager.StoneCountUp();
            gameManager.StoneCountUp();
            StoneCount--;
            StoneCount--;
            StoneCount--;
        }
        

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wood")
        {
            gameManager.WoodCountDown();
            WoodCount++;
        }
        if (other.gameObject.tag == "Stone")
        {
            gameManager.StoneCountDown();
            StoneCount++;
        }
        if (other.gameObject.tag == "BigStone")
        {
            gameManager.StoneCountDown();
            gameManager.StoneCountDown();
            gameManager.StoneCountDown();
            StoneCount++;
            StoneCount++;
            StoneCount++;
        }
    }

    public void ButtonPush()
    {
        Building.gameObject.SetActive(true);
    }
    void TextUpdate()
    {
        Debug.Log("TextUpdate");
        
        Woodtext.text = WoodCount.ToString();

        
        Stonetext.text = StoneCount.ToString();
    }

    public void Build()
    {
        Button.SetActive(true);
        Debug.Log("Button Is Active");
    }
}
