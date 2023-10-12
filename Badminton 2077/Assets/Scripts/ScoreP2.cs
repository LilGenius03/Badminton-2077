using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreP2 : MonoBehaviour
{
    public int score;

    [SerializeField]
    private Text scoreText;

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("ShuttleCatchP2").GetComponent<ScoreboardP2>().player2Score;
        scoreText.text = score.ToString();
    }
}
