using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButtonScript : MonoBehaviour
{
     private GameObject playerObject;
     PlayerControll playerControll;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        playerControll = playerObject.GetComponent< PlayerControll>();
        
    }

    public void OnButtonDown()
    {
        playerControll.x = -1;
    }

    public void OnButtonUp()
    {
        playerControll.x = 0;
    }

}
