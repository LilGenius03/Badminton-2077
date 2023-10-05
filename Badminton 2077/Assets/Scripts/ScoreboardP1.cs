using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreboardP1 : MonoBehaviour
{
    public int player1Score;
    int player2Score;
    public bool VictoryP1;
    public bool ResetShuttle;
    public bool ShuttleScored;

    private void Start()
    {
        player1Score = 0;
        VictoryP1 = false;
        player2Score = GameObject.Find("ShuttleCatchP2").GetComponent<ScoreboardP2>().player2Score;
        ResetShuttle = false;
    }

    private void OnCollisionEnter2D(Collision2D Shuttle)
    {
        player1Score += 1;
        ResetShuttle = true;
    }

    // Update is called once per frame
    void Update()
    {
        ShuttleScored = GameObject.Find("Shuttle").GetComponent<Shuttle>().ShuttleScored;

        if (ShuttleScored == true)
        {
            ResetShuttle = false;
        }

        if (player1Score > player2Score + 1 & player1Score > 11)
        {
            VictoryP1 = true;
        }
    }
}
