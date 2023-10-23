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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Shuttle"))
        {
            PlayerHit.Play();
            hit.Play();
            col.GetComponent<Shuttle>().target = col.GetComponent<Shuttle>().target + (7 * player) + (power * hand);
            col.GetComponent<Shuttle>().speed = speed;
            col.GetComponent<Shuttle>().change = change;
            power = 1;
            speed = 10;
            change = false;
        }
    }
}
