using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_animation : MonoBehaviour
{
   	public AnimationClip hit;
   	Animation anim;

    void Start()
    {
    	anim = GetComponent<Animation>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
        	anim.clip = hit;
        	anim.Play();
        }
    }
}
