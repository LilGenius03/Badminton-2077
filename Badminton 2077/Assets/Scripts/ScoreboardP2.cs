using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreboardP2 : MonoBehaviour
{
    public int player2Score;
    int player1Score;
    public bool VictoryP2;
    public bool ShuttleReset;
    public bool ShuttleScored;

    private void Start()
    {
        player2Score = -1;
        VictoryP2 = false;
        player1Score = GameObject.Find("ShuttleCatchP1").GetComponent<ScoreboardP1>().player1Score;
        ShuttleReset = false;
    }

    private void OnCollisionEnter2D(Collision2D Shuttle)
    {
        player2Score += 1;
        ShuttleReset = true;
    }

    // Update is called once per frame
    void Update()
    {
        ShuttleScored = GameObject.Find("Shuttle").GetComponent<Shuttle>().ShuttleScored;

        if (ShuttleScored == true)
        {
            ShuttleReset = false;
        }


        if (player2Score > player1Score + 1 & player2Score > 11)
        {
            VictoryP2 = true;
        }

    }
}
