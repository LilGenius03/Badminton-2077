using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class BoostPower : MonoBehaviour
{
    public Hit hit;
    public Player1Movement player1;
    public Player2Movement player2;
    public GameObject Player1;
    public GameObject Player2;

    private void Start()
    {
        hit = Player1.GetComponent<Hit>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.G))
        {
            PowerPlayer1();
        }

        if(Input.GetKey(KeyCode.K) && Input.GetKey(KeyCode.L))
        {
            PowerPlayer2();
        }
    }

    public void PowerPlayer1()
    {
       player1 = Player1.GetComponent<Player1Movement>();
       
        if(player1.currentMeter >= 25 && player1.currentMeter <= 49)
        {
            hit.power += 5;
        }

        else if(player1.currentMeter >= 50)
        {
            hit.power += 8;
        }
    }

    public void PowerPlayer2()
    {
        player2 = Player2.GetComponent<Player2Movement>();

        if (player2.currentMeter >= 25 && player2.currentMeter <= 49)
        {
            hit.power += 5;
        }

        else if (player2.currentMeter >= 50)
        {
            hit.power += 8;
        }
    }
}
