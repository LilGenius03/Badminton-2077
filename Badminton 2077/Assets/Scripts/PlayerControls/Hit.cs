using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int hand;
    public int player;
    public float speed;
    public int power;
    public bool change;
    public AudioSource hit;
    public ParticleSystem PlayerHit;
    public int powerUp;
    public int upDown;

    void Start()
    {
        upDown = hand * -1;
        powerUp = RacketPicker.p1Select;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Shuttle"))
        {
            PlayerHit.Play();
            hit.Play();
            col.GetComponent<Shuttle>().target = col.GetComponent<Shuttle>().target + (7 * player) + (power * hand);
            col.GetComponent<Shuttle>().speed = speed;
            col.GetComponent<Shuttle>().change = change;
            if(change)
            {
                col.GetComponent<Shuttle>().upDown = upDown;
            }
            power = 1;
            speed = 15;
            change = false;
        }
    }

    public void PowerUp()
    {
        switch(powerUp)
        {
            case 0:
                power = 2;
                break;
            case 1:
                speed = 20;
                break;
            case 2:
                change = true;
                upDown = hand * -1;
                break;
            default:
                power = 1;
                speed = 15;
                change=false;
                break;
        }
    }

    public void Power2()
    {
        switch (powerUp)
        {
            case 0:
                power = 3;
                break;
            case 1:
                speed = 25;
                break;
            case 2:
                upDown = Random.Range(-1, 2);
                change = true;
                break;
            default:
                power = 1;
                speed = 15;
                change = false;
                break;
        }
    }
}
