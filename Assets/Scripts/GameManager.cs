using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
	private Text scoreText1;
	private Text scoreText2;

	// Use this for initialization
	void Start () 
	{
		scoreText1 = GameObject.Find("ScoreText1").GetComponent<Text>();
		scoreText2 = GameObject.Find("ScoreText2").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreText1.text = "Score: " + score.ToString();
		scoreText2.text = "Score: " + score.ToString();
		Debug.Log(score);
	}
}
