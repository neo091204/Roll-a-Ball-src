using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 下ボタンの処理
public class DownButtonScript : MonoBehaviour
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
        playerControll.z = -1;
    }

    public void OnButtonUp()
    {
        playerControll.z = 0;
    }
}
