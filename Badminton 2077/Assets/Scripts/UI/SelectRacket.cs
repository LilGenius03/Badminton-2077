using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectRacket : MonoBehaviour
{
    public bool Rocket1Chosen;
    public bool Power1Chosen;
    public bool ZigZag1Chosen;

    public bool Rocket2Chosen;
    public bool Power2Chosen;
    public bool ZigZag2Chosen;

    public bool RocketSelect;
    public bool PowerSelect;
    public bool ZigZagSelect;

    public int Options;

    // Start is called before the first frame update
    void Start()
    {
        Rocket1Chosen = false;
        Power1Chosen = false;
        ZigZag1Chosen = false;

        Rocket2Chosen = false;
        Power2Chosen = false;
        ZigZag2Chosen = false;

        RocketSelect = false;
        PowerSelect = false;
        ZigZagSelect = false;

        Options = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Options++;
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Options--;
        }

        if (Options < 0)
        {
            Options = 0;
        }

        if (Options > 2)
        {
            Options = 2;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (PowerSelect == true & !Power1Chosen & !Rocket1Chosen & !ZigZag1Chosen)
            {
                Power1Chosen = true;
            }

            if (RocketSelect == true & !Power1Chosen & !Rocket1Chosen & !ZigZag1Chosen)
            {
                //Rocket1Chosen = true;
            }

            if (ZigZagSelect == true & !Power1Chosen & !Rocket1Chosen & !ZigZag1Chosen)
            {
                //ZigZag1Chosen = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (PowerSelect == true & !Power2Chosen & !Rocket2Chosen & !ZigZag2Chosen)
            {
                Power2Chosen = true;
            }

            if (RocketSelect == true & !Power2Chosen & !Rocket2Chosen & !ZigZag2Chosen)
            {
                //Rocket2Chosen = true;
            }

            if (ZigZagSelect == true & !Power2Chosen & !Rocket2Chosen & !ZigZag2Chosen)
            {
                //ZigZag2Chosen = true;
            }
        }

        if (Options == 0)
        {
            PowerSelect = true;
            RocketSelect = false;
            ZigZagSelect = false;
        }

        if (Options == 1)
        {
            PowerSelect = false;
            RocketSelect = true;
            ZigZagSelect = false;
        }

        if (Options == 2)
        {
            PowerSelect = false;
            RocketSelect = false;
            ZigZagSelect = true;
        }

        if (Power1Chosen == true & Power2Chosen == true)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
