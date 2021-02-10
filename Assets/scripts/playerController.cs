using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
public class playerController : MonoBehaviour
{
	public Rigidbody2D rb;


	public float runspeed = 5f;

	public Vector2 lastPos;
	
	public Vector3 startPos = new Vector3(-3,4,0);
	

	public bool onPlatform = false;

	float horizontalMove = 0f;
	
	bool jump = false;

    public AudioSource audioSource;

	public AudioClip clip;

	public float volume = 0.5f;

	bool played;

    void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
        lastPos = transform.position;
    }

    public void ReloadLevel() {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void moveTo(Vector3 movePos) {
		transform.position = movePos;
    }

	public void stopMotion() {
		rb.velocity = new Vector2 (0, 0);
	}

    bool hasMoved() {
    	Vector2 displacement = new Vector2(transform.position.x - lastPos.x,
    									 transform.position.y - lastPos.y);
    	lastPos = transform.position;
    	if(displacement.magnitude < 0.00001) {
    		return false;
    	}
    	return true;
    }

    void Update() {
    	
		horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
		
		jump = Input.GetKey(KeyCode.Space);

        if(Input.GetKey(KeyCode.Space)) {
			if(onPlatform){
				rb.velocity = new Vector2(rb.velocity.x, 7);
			}	
        }

        if(Input.GetKey(KeyCode.R)) {
        		ReloadLevel();
        }
    }

	void FixedUpdate()
	{
		//to only let the player jump when on the platform
		if(onPlatform) {
			rb.AddForce(new Vector2(horizontalMove, 0f));	
		}
		else{
			rb.AddForce(new Vector2(horizontalMove/2, 0f));
		}

		if(transform.position.y < -10 && !played) {
			audioSource.PlayOneShot(clip, volume);
			played = true;
		}
		if(transform.position.y > -10){
				played = false;
		}

		if(transform.position.y < -50) {
			audioSource.Stop();
			moveTo(startPos);
			audioSource.Play();
		}

	}
}
