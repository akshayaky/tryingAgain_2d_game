using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    	
    public AudioSource audioS1;
    public AudioSource audioS2;
    public AudioSource audioS3;
    private int currentAudioS;
    void Start()
    {
        currentAudioS = Random.Range(0,3);
        Debug.Log(currentAudioS);
    }

    // Update is called once per frame
    void Update()
    {
    	if( !audioS1.isPlaying && !audioS2.isPlaying && !audioS2.isPlaying )
    	{
    		currentAudioS = Random.Range(0,3);
	        if(currentAudioS == 0) {
	        	audioS1.Play();
	        }
	        else if(currentAudioS == 1) {
	        	audioS2.Play();
	        }
	        else if(currentAudioS == 2) {
	        	audioS3.Play();
	        }
    	}
    }
}
