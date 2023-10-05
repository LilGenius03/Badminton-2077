using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBarrier : MonoBehaviour
{
    
    public Shuttle shuttle;
    public float slowDown = 0.1f;
    
    

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shuttle")
        {
            Shuttle shuttle = GetComponent<Shuttle>();
            shuttle.speed -= slowDown;
            Debug.Log(shuttle.speed);

        }
    }
}
