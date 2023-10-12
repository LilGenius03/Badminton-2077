using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float gridSize = 1f;
    private float x, y;

    private bool Racket1On = true;
    private bool Racket2On = false;
    public int MinSupeMeter = 0;
    public int currentMeter;

    public SuperMeter Supermeter;

    public GameObject Racket1;
    public GameObject Racket2;
    public GameObject player2Sprite;
    public AudioSource hit;
    public AudioSource PowershotTierOne;
    public AudioSource PowershotTierTwo;
    public ParticleSystem SuperMeterhalfWay;



    // Start is called before the first frame update
    void Start()
    {
        Supermeter.SetMeter(MinSupeMeter);
    }

    // Update is called once per frame
    void Update()
    {
        bool uparrow = Input.GetKeyDown(KeyCode.UpArrow);
        bool downarrow = Input.GetKeyDown(KeyCode.DownArrow);
        bool rightarrow = Input .GetKey(KeyCode.RightArrow);
        bool power = Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow);


        if (uparrow)
        {
            y = gridSize;
            MeterIncrease(1);
        }
        if (downarrow)
        {
            y = -gridSize;
            MeterIncrease(1);
        }
        transform.Translate(x, y, 0);
        x = 0;
        y = 0;

        if(rightarrow)
        {
            hit.Play();
        }

        if (currentMeter == 25)
        {
            SuperMeterhalfWay.Play();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Racket1On == true)
        {
            Racket1On = false;
            Racket2On = true;
            Racket1.SetActive(false);
            Racket2.SetActive(true);
        }

        else if(Input.GetKeyDown(KeyCode.LeftArrow) && Racket2On == true)
        {
            Racket2On = false;
            Racket1On = true;

            Racket2.SetActive(false);
            Racket1.SetActive(true);
        }

        if(power)
        {
            if(currentMeter >= 25 && currentMeter <= 49)
            {
                MeterIncrease(-25);
                PowershotTierOne.Play();
                hit.Stop();
            }

            else if(currentMeter >= 50)
            {
                MeterIncrease(-currentMeter);
                PowershotTierTwo.Play();
                hit.Stop();
            }
        }

        else if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow) && currentMeter == 50)
        {
            currentMeter = 0;
            
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
