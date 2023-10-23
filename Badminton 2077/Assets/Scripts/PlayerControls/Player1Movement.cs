using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Player1Movement : MonoBehaviour
{
    public int racketType;
    public Animator anim;
    public  float gridSize = 1f;
    private float x, y;
    
    private bool Racket1On;
    private bool Racket2On;
    public SuperMeter Supermeter;
    //public AudioSource hit;
    public AudioSource PowershotTierOne;
    public AudioSource PowershotTierTwo;
    public ParticleSystem SuperMeterhalfWay;
    public int MinSupeMeter = 0;
    public int currentMeter;
    float timer;
    //float holdTime = 2.0f;

    public GameObject playerSprite;
    public GameObject Racket1;
    public GameObject Racket2;
    // Start is called before the first frame update
    void Start()
    {
        racketType = RacketPicker.p1Select;
        Racket1.SetActive(true);
        Racket2.SetActive(false);
        Supermeter.SetMeter(MinSupeMeter);
    }

    // Update is called once per frame
    void Update()
    {
        bool w = Input.GetKeyDown(KeyCode.W);
        bool s = Input.GetKeyDown(KeyCode.S);
        bool a = Input.GetKeyDown(KeyCode.G);
        bool d = Input.GetKeyDown(KeyCode.F);
        bool power = Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.G);

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
        
        if (a && power == false)
        {
            /*if (Racket1On == true && Racket2On != true)
            {
                anim.SetTrigger("SwingTop");
            }
            else if (Racket1On != true && Racket2On == true)
            {
                anim.SetTrigger("SwingBottom");
            }*/
            Racket1On = false;
            Racket2On = true;

            Racket1.SetActive(false);
            Racket2.SetActive(true);

            anim.SetTrigger("SwingBottom");
        }
        
        if (d && power == false)
        {
            Racket1On = true;
            Racket2On = false;

            Racket1.SetActive(true);
            Racket2.SetActive(false);

            anim.SetTrigger("SwingTop");
        }
        transform.Translate(x, y, 0);
        x = 0;
        y = 0;

        if(currentMeter == 25)
        {
            SuperMeterhalfWay.Play();
        }

        SuperMeter();

        /*if (Input.GetKeyDown(KeyCode.D) && Racket1On == true && power == false)
        {
            Racket1On = false;
            Racket2On = true;
            Racket1.SetActive(false);
            Racket2.SetActive(true);
        }

        else if(Input.GetKeyDown(KeyCode.D) && Racket2On == true && power == false)
        {
            Racket2On = false;
            Racket1On = true;
      
            Racket2.SetActive(false);
            Racket1.SetActive(true); 
        }*/

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

    public void SuperMeter()
    {
        bool power = Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.G);

        if (power)
        {
            if (currentMeter >= 25 && currentMeter <= 49)
            {
                MeterIncrease(-25);
                PowershotTierOne.Play();
                if (Racket1On == true && Racket2On != true)
                {
                    anim.SetTrigger("SwingTop");
                    if(RacketPicker.p1Select == 1)
                    {
                        Racket1.GetComponent<Hit>().power = 2;
                    }
                    
                }
                else if (Racket1On != true && Racket2On == true)
                {
                    anim.SetTrigger("SwingBottom");
                    if (RacketPicker.p1Select == 1)
                    {
                        Racket2.GetComponent<Hit>().power = 2;
                    }
                }
            }

            else if (currentMeter >= 50)
            {
                MeterIncrease(-currentMeter);
                PowershotTierTwo.Play();
                if (Racket1On == true && Racket2On != true)
                {
                    anim.SetTrigger("SwingTop");
                }
                else if (Racket1On != true && Racket2On == true)
                {
                    anim.SetTrigger("SwingBottom");
                }
            }
        }
    }
}
