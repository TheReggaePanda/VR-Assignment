using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CollectionPoint : MonoBehaviour
{
    

    public int WoodMax;
    public int StoneMax;
    private int WoodCount;
    private int WoodCounter;
    private int StoneCounter;
    private int StoneCount;
    public GameObject Button;
    public GameObject Building;
    public TextMeshProUGUI Woodtext;
    public TextMeshProUGUI Stonetext;

    private List<GameObject> myGameObjects = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        

        WoodCount = WoodMax;
        StoneCount = StoneMax;

        TextUpdate();
    }

   
    // Update is called once per frame
    void Update()
    {
        TextUpdate();

        if(WoodMax <= WoodCounter && StoneMax <= StoneCounter)
        {
            Build();
        }
        else
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
            StoneCounter--; StoneCounter--; StoneCounter--;
            StoneCount++;
            StoneCount++;
            StoneCount++;
        }

        RemoveGameObject(other.gameObject);
    }

    public void ButtonPush()
    {
        Building.gameObject.SetActive(true);
        Button.SetActive(false);

        foreach (GameObject obj in myGameObjects) 
        {
            myGameObjects.Remove(obj);
            Destroy(obj);
        }
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
