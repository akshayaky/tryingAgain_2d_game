using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code to keep the audio source alive between scenes to keep the background score playing
public class dontDestroy : MonoBehaviour
{

    void Awake() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1) {
        	Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
