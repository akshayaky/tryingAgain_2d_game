using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//play button at the start of the game loads the first level
public class playButton : MonoBehaviour
{
    public void PlayGame() {
    	SceneManager.LoadScene(1);
    }

}
