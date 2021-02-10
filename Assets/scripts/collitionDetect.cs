using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class collitionDetect : MonoBehaviour
{
	// ScriptName sn = gameObject.GetComponent<playerController>();
	public GameObject gb;
	// public AudioSource audioSource;

	// public AudioClip clip;

	public float volume = 0.5f;


	IEnumerator OnCollisionEnter2D(Collision2D col) {

		if(col.gameObject.tag == "weak_platform") {
			gb = col.gameObject;
			// audioSource.PlayOneShot(clip, volume);
			yield return new WaitForSeconds (1);
			Destroy(gb);
		}
		else if(col.gameObject.tag == "enemy") {
			gameObject.GetComponent<playerController>().moveTo(new Vector3(-3, 4, 0));
		}
    }
    void OnCollisionStay2D(Collision2D col) {
    	if (col.gameObject.tag.Contains("platform")) {
			gameObject.GetComponent<playerController> ().onPlatform = true;
		}
    }
	void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject.tag.Contains("platform")) {
			gameObject.GetComponent<playerController> ().onPlatform = false;
		}
	}
}
