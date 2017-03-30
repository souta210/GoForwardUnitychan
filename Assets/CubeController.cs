using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	private float speed = -0.2f;
	public AudioSource audio1;

	private float deadLine = -10;
	// Use this for initialization
	void Start () {
		audio1 = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(speed,0,0);

		if (transform.position.x < deadLine) {
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "groundtag" || other.gameObject.tag == "blocktag") {
			audio1.Play();
		}
	}
}