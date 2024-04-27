using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class ToDoCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI Woodtext;
    public TextMeshProUGUI Stonetext;
    private int WoodCount;
    private int StoneCount;

    CollectionPoint collectionPoint;


    void Start()
    {
        collectionPoint=gameObject.GetComponent<CollectionPoint>();

        TextUpdate();

    }

    // Update is called once per frame
    void Update()
    {
        TextUpdate();
    }

    void TextUpdate()
    {
        WoodCount = collectionPoint.WoodMax;
        Woodtext.text = WoodCount.ToString();

        StoneCount = collectionPoint.StoneMax;
        Stonetext.text = StoneCount.ToString();
    }
}
