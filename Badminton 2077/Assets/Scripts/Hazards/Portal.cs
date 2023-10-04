using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    
    private Transform destination;

    public bool isOrange;
    public float distance = 0.2f;
    void Start()
    {
        if(isOrange == false)
        {
            destination = GameObject.FindGameObjectWithTag("Orange Portal").GetComponent<Transform>();
        }

        else
        {
            destination = GameObject.FindGameObjectWithTag("Blue Portal").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(Vector2.Distance(transform.position,collision.transform.position) > distance)
        {
            Vector2 vector2 = new Vector2(destination.position.x, destination.position.y);
            collision.transform.position = vector2;
        }
    }
}
