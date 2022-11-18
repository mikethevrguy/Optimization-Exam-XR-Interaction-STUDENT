using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    [SerializeField]
    Text scoreText, scoreText2;
    public int score;

    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score" + score;
        scoreText2.text = "Score" + score;
    }
	
}
