using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int WoodCounter;
    private int StoneCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WoodCountUp()
    {
        WoodCounter++;
        Debug.Log("woodcounter is" + WoodCounter);
    }
    public void WoodCountDown()
    {
        WoodCounter--;
        Debug.Log("woodcounter is" + WoodCounter);
    }

    public void StoneCountUp()
    {
        StoneCounter++;
        Debug.Log("StoneCounter is" + StoneCounter);
    }
    public void StoneCountDown()
    {
        StoneCounter--;
        Debug.Log("StoneCounter is" + StoneCounter);
    }

    public int Wood()
    {
        return WoodCounter;
    }    
    public int Stone()
    {
        return StoneCounter;
    }

    


}
