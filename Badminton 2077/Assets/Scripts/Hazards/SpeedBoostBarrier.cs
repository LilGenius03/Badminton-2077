using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostBarrier : MonoBehaviour
{
    public Shuttle shuttle;
    public float speedBoost = 0.5f;
    public GameObject Shuttle;
    // Start is called before the first frame update

    private void Start()
    {
        shuttle = Shuttle.GetComponent<Shuttle>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shuttle")
        {
            shuttle.speed += speedBoost;
            Debug.Log(shuttle.speed);

        }
    }
}
