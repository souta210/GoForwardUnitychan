using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {
	public GameObject CubePreFab;

	private float delta = 0f;//時間計測用
	private float span = 1.0f;//生成間隔
	private float genPosX = 12;
	private float offsetY = 0.3f;
	private float spaceY = 6.9f;
	private float offsetX = 0.5f;
	private float spaceX = 0.4f;
	private int maxBlockNum = 4;

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		delta += Time.deltaTime;

		if (delta > span) {
			delta = 0;
			int n = Random.Range (1,maxBlockNum + 1);
			//iの初期値０、iがn以下の間、iに１足して。n以下の時はgoというCubePreFabに対して位置の変更(makeBlock desune)を行って
			for (int i = 0; i < n; i++) {
				GameObject go = Instantiate (CubePreFab) as GameObject;
				go.transform.position = new Vector2 (genPosX, offsetY + i * spaceY);
			}
			span = offsetX + spaceX * n;//次のブロック生成時間
		}
		
	}
}

