using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DagerWallScript : MonoBehaviour
{

    void OnCollisionEnter (Collision hit)
    {
        if (hit.gameObject.CompareTag ("Player")) {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

}
