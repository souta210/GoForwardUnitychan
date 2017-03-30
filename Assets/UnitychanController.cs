using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanController : MonoBehaviour {
	Animator animator;
	Rigidbody2D rigid2D;


	private float groundLevel = -3.0f;
	private float dump = 0.8f;
	float jumpVelocity = 20;
	private float deadline = -9;
	// Use this for initialization

	void Start () {
		animator = GetComponent<Animator> ();
		rigid2D = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("Horizontal", 1);

		bool isGround = (transform.position.y > groundLevel) ? false : true;
		animator.SetBool ("isGround", isGround);  //animatorにbool値をisGroundd内で渡して

		//ボタンが押された且つisGroundがtrueの時
		if (Input.GetMouseButtonDown (0) && isGround) {
			this.rigid2D.velocity = new Vector2 (0, this.jumpVelocity);
		}
		//ボタンが押されていないならば
		if (Input.GetMouseButton (0) == false) {
			if (this.rigid2D.velocity.y > 0) {
				this.rigid2D.velocity *= this.dump;
			}
		}
		if (transform.position.x < deadline) {
			GameObject.Find ("Canvas").GetComponent<UIcontroller> ().GameOver ();
			Destroy (gameObject);
		}
		GetComponent<AudioSource> ().volume = (isGround) ? 1 : 0;
		}


}
