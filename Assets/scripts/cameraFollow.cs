using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cameraFollow : MonoBehaviour
{	
	public Transform player;
	public Vector3 posiut;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    	// if(Mathf.Abs(transform.position.x - player.position.x) > 10)
     //    	transform.position = new Vector3(player.position.x,
     //    										player.position.y, -10);
        // transform.position = new Vector3(player.position.x, 
        //                                         player.position.y, -10);
    }
}
