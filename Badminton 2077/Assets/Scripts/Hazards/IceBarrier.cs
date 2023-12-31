using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBarrier : MonoBehaviour
{
    
    public Shuttle shuttle;
    public float slowDown = 0.1f;

    private void Start()
    {
        shuttle = GameObject.Find("Shuttle").GetComponent<Shuttle>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shuttle")
        {
            shuttle.speed -= slowDown;
            Debug.Log(shuttle.speed);

        }
    }
}
