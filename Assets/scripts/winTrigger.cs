using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//to load the next level when the player enters the win trigger
public class winTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collition) {
    	GameObject collitionObject = collition.gameObject;
    	if(collitionObject.name == "box") {
    		LoadScene();
    	}
    }
    void LoadScene() {
    	Debug.Log(SceneManager.GetActiveScene().buildIndex);
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
