using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTxt : MonoBehaviour{

    public int score;
    public int scoreMultiplier;
    public TMP_Text scoreText;
    private float timeCount = 0;

    void Start(){
        score = 0;
        PlayerPrefs.SetInt("ScoreMultiplier",1);
        scoreText.text = score.ToString() + " Score";
    }

    void Update(){
        timeCount += Time.deltaTime;
        if(timeCount > 0.03f){
            scoreMultiplier = PlayerPrefs.GetInt("ScoreMultiplier");    //maybe optimize
            score += 1 * scoreMultiplier;
            scoreText.text = score.ToString() + " Score";
            timeCount = 0;
        }
    }

    public int getScore(){
        return score;
    }
}
