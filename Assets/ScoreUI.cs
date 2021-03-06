﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUI : MonoBehaviour {

	Global globalObj;
	Text scoreText;
	// Use this for initialization
	void Start () {
		GameObject g = GameObject.Find ("GlobalObject");
		globalObj = g.GetComponent< Global >();
		globalObj.score = 0;
		scoreText = gameObject.GetComponent<Text>();
	}
	// Update is called once per frame
	void Update () {
		scoreText.text = globalObj.score.ToString();
	}
}
