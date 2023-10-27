using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public Animator anim;
    public float gridSize = 1f;
    private float x, y;

    private bool Racket1On = false;
    private bool Racket2On = true;
    public int MinSupeMeter = 0;
    public int currentMeter;

    public SuperMeter Supermeter;

    public GameObject Racket1;
    public GameObject Racket2;
    public GameObject player2Sprite;
    //public AudioSource hit;
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
        bool rightarrow = Input.GetKeyDown(KeyCode.L);
        bool leftarrow = Input.GetKeyDown (KeyCode.K);
        bool power = Input.GetKey(KeyCode.L) && Input.GetKey(KeyCode.K);


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

        if(rightarrow && power == false)
        {
            /*if (Racket1On == true && Racket2On != true)
            {
                anim.SetTrigger("SwingTop");
            }
            else if (Racket1On != true && Racket2On == true)
            {
                anim.SetTrigger("SwingBottom");
            }*/
            Racket1On = true;
            Racket2On = false;

            Racket1.SetActive(true);
            Racket2.SetActive(false);

            anim.SetTrigger("SwingTop");
        }

        if (leftarrow && power == false)
        {
            Racket1On = false;
            Racket2On = true;

            Racket1.SetActive(false);
            Racket2.SetActive(true);

            anim.SetTrigger("SwingBottom");
        }

        if (currentMeter == 25)
        {
            SuperMeterhalfWay.Play();
        }

        SuperMeter();

        /*if (Input.GetKeyDown(KeyCode.LeftArrow) && Racket1On == true && power == false)
        {
            Racket1On = false;
            Racket2On = true;
            Racket1.SetActive(false);
            Racket2.SetActive(true);
        }

        else if(Input.GetKeyDown(KeyCode.LeftArrow) && Racket2On == true && power == false)
        {
            Racket2On = false;
            Racket1On = true;

            Racket2.SetActive(false);
            Racket1.SetActive(true);
        }*/

        /*if(power)
        {
            if(currentMeter >= 25 && currentMeter <= 49)
            {
                MeterIncrease(-25);
                PowershotTierOne.Play();
                if (Racket1On == true && Racket2On != true)
                {
                    anim.SetTrigger("SwingTop");
                }
                else if (Racket1On != true && Racket2On == true)
                {
                    anim.SetTrigger("SwingBottom");
                }
            }

            else if(currentMeter >= 50)
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

        /*else if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow) && currentMeter == 50)
        {
            currentMeter = 0;
            
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
                    Racket1.GetComponent<Hit>().PowerUp();
                    //Hit sn = Racket1.GetComponent<Hit>();
                    //sn.PowerUp();

                }
                else if (Racket1On != true && Racket2On == true)
                {
                    anim.SetTrigger("SwingBottom");
                    Racket2.GetComponent<Hit>().PowerUp();
                }
            }

            else if (currentMeter >= 50)
            {
                MeterIncrease(-currentMeter);
                PowershotTierTwo.Play();
                if (Racket1On == true && Racket2On != true)
                {
                    anim.SetTrigger("SwingTop");
                    Racket1.GetComponent<Hit>().Power2();
                }
                else if (Racket1On != true && Racket2On == true)
                {
                    anim.SetTrigger("SwingBottom");
                    Racket2.GetComponent<Hit>().Power2();
                }
            }
        }
    }
}
