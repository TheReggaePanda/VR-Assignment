using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CollectionPoint : MonoBehaviour
{

    private bool hasBuilt = false;
    public int WoodMax;
    public int StoneMax;
    private int WoodCount;
    private int WoodCounter;
    private int StoneCounter;
    private int StoneCount;
    private int gameObjectCount;
    public GameObject Button;
    public GameObject Building;
    public TextMeshProUGUI Woodtext;
    public TextMeshProUGUI Stonetext;
    SceneChanger changer;
    private List<GameObject> myGameObjects = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        changer = GameObject.Find("GameManager").GetComponent<SceneChanger>();

        WoodCount = WoodMax;
        StoneCount = StoneMax;

        TextUpdate();
    }

   
    // Update is called once per frame
    void Update()
    {
        TextUpdate();

        if(WoodMax <= WoodCounter && StoneMax <= StoneCounter && hasBuilt == false)
        {
            Build();
        }
        else if(hasBuilt == false)
        {
            Unbuild();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wood")
        {
            WoodCounter++;
            WoodCount--;
        }
        if (other.gameObject.tag == "Stone")
        {
            StoneCounter++;
            StoneCount--;
        }
        if (other.gameObject.tag == "BigStone")
        {
            StoneCounter++;
            StoneCounter++; 
            StoneCounter++;
            StoneCount--;
            StoneCount--;
            StoneCount--;
        }
        if (other.gameObject.tag == "BigWood")
        {
            WoodCount--;
            WoodCounter++;
            WoodCount--;
            WoodCounter++;
            WoodCount--;
            WoodCounter++;
        }

        AddGameObject(other.gameObject);

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wood")
        {
            WoodCounter--;
            WoodCount++;
        }
        if (other.gameObject.tag == "Stone")
        {
            StoneCounter--;
            StoneCount++;
        }
        if (other.gameObject.tag == "BigStone")
        {
            StoneCounter--;
            StoneCounter--;
            StoneCounter--;
            StoneCount++;
            StoneCount++;
            StoneCount++;
        }
        if(other.gameObject.tag == "BigWood")
        {
            WoodCounter--;
            WoodCount++;
            WoodCounter--;
            WoodCount++;
            WoodCounter--;
            WoodCount++;
        }

        RemoveGameObject(other.gameObject);
    }

    public void ButtonPush()
    {
        Building.gameObject.SetActive(true);
        
        gameObjectCount = myGameObjects.Count;

        for(int i = 0; i < gameObjectCount; i++)
        {
            Destroy(myGameObjects[i]);
        }

        changer.addScore();

        hasBuilt = true;

        Button.SetActive(false);
        
    }
    void TextUpdate()
    {
        
        
        Woodtext.text = WoodCount.ToString();

        
        Stonetext.text = StoneCount.ToString();
    }

    public void Build()
    {
        Button.SetActive(true);
        
    }

    public void Unbuild()
    {
        Button.SetActive(false);
       
    }

    public void AddGameObject (GameObject gameObject)
    {
        myGameObjects.Add(gameObject);
        Debug.Log("Added");
    }

    public void RemoveGameObject (GameObject gameObject) 
    {
        myGameObjects.Remove(gameObject);
        Debug.Log("Removed");
    }
}
