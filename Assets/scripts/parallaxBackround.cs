using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to create parallax effect on the background
public class parallaxBackround : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 lastCameraPosition;
	[SerializeField] private float parallaxEffectMultiplier;
	private float textureUnitSizeX;

    void Start()
    {
        playerTransform = Camera.main.transform;
        lastCameraPosition = playerTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;

        textureUnitSizeX = texture.width/ sprite.pixelsPerUnit;
    }

    void LateUpdate() {
    	Vector3 deltaMovement = playerTransform.position - lastCameraPosition;
    	transform.position += new Vector3(deltaMovement.x*parallaxEffectMultiplier, 0, 0);
    	lastCameraPosition = playerTransform.position;
    	
    	if(Mathf.Abs(playerTransform.position.x - transform.position.x) >= textureUnitSizeX*2) {
    		
    		float offsetPositionX = (playerTransform.position.x - transform.position.x);//% textureUnitSizeX;
    		Debug.Log((playerTransform.position.x));
    		transform.position = new Vector3(playerTransform.position.x + 0,
    												 transform.position.y, transform.position.z);
    	}
    }

}
