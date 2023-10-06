using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Player1Movement : MonoBehaviour
{
    public  float gridSize = 1f;
    private float x, y;
    
    private bool Racket1On = true;
    private bool Racket2On = false;
    public SuperMeter Supermeter;
    public int MinSupeMeter = 0;
    public int currentMeter;
    public float HoldTime = 2;
    
    //float holdTime = 2.0f;

    public GameObject playerSprite;
    public GameObject Racket1;
    public GameObject Racket2;
    // Start is called before the first frame update
    void Start()
    {
        Supermeter.SetMeter(MinSupeMeter);
    }

    // Update is called once per frame
    void Update()
    {
        bool w = Input.GetKeyDown(KeyCode.W);
        bool s = Input.GetKeyDown(KeyCode.S);
        bool power = Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D);

        if (w)
        {
            y = gridSize;
            MeterIncrease(1);

        }
        if (s)
        {
            y = -gridSize;
            MeterIncrease(1);

        }
        transform.Translate(x, y, 0);
        x = 0;
        y = 0;

        if (power)
        {
            if (currentMeter >= 25 && currentMeter <= 49)
            {
                MeterIncrease(-25);
            }

            else if (currentMeter >= 50)
            {
                MeterIncrease(-currentMeter);
            }
        }





        /*if (!a)
        {
            timer = 0f;
        }*/

        if (Input.GetKeyDown(KeyCode.D) && Racket1On == true)
        {
            Racket1On = false;
            Racket2On = true;
            Racket1.SetActive(false);
            Racket2.SetActive(true);
        }

        else if(Input.GetKeyDown(KeyCode.D) && Racket2On == true)
        {
            Racket2On = false;
            Racket1On = true;
      
            Racket2.SetActive(false);
            Racket1.SetActive(true); 
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            y = -gridSize;
        }
        if (collision.collider.tag == "Obstacle2")
        {
            y = gridSize;
        }
    }

    void MeterIncrease(int increase)
    {
        currentMeter += increase;
        Supermeter.SetMeter(currentMeter);
    }
}
