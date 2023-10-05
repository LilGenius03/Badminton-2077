using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreP1 : MonoBehaviour
{
    public int score;

    [SerializeField]
    private Text scoreText;

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("ShuttleCatchP1").GetComponent<ScoreboardP1>().player1Score;
        scoreText.text = "Score: " + score.ToString();
    }
}
