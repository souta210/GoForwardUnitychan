using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class UIcontroller : MonoBehaviour {

	private GameObject gameoverText;
	private GameObject runlengthText;
	private float len = 0;
	private float speed = 0.03f;
	private bool isGameOver = false;

	// Use this for initialization
	void Start () {
		gameoverText = GameObject.Find("GameOver");
		runlengthText = GameObject.Find ("RunLenght");

	}
	
	// Update is called once per frame
	void Update () {
		if( isGameOver == false){
			len += speed;
			runlengthText.GetComponent<Text> ().text = "Distance:  "  + len.ToString ("F2") + "m";
		
	}
		if(isGameOver){
			if(Input.GetMouseButtonDown(0)){
				SceneManager.LoadScene("GameScene");
			}
}
				}
	public void GameOver(){
		gameoverText.GetComponent<Text> ().text = "GameOver";
		isGameOver = true;
	}
}
