using System.Collections;
using System.Collections.Generic;
using TMPro;
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
