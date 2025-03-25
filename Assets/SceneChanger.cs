using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int sceneBuildIndex;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        print("Trigger Entered");

        if(other.tag == "Player")
        {
            print("Moving to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        } 
    }
}
