using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
    public Text scoreText1, scoreText2;

    public void UpdateScore()
    {
        score++;
        scoreText1.text = "Score" + score;
        scoreText2.text = "Score" + score;

    }

}
