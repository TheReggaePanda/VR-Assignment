using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRetrieval : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject game;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.position = game.transform.position;
    }
}
