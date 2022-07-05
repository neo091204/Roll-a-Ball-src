using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerControll.csからxを読み取って、値変更
// ボタンが離された時にx = 0
// 左ボタン、上下ボタン追加

public class ButtonScript : MonoBehaviour
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
        playerControll.z = 1;
    }

    public void OnButtonUp()
    {
        playerControll.z = 0;
    }

}
