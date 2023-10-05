using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Shuttle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float rotationSpeed = 1f;
    public float rotationTime = 2f;
    public float WaitForRotation = 3f;
    float timeleft;
    public bool ShuttleReset;
    public bool ResetShuttle;
    public bool ShuttleScored;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Launch());
        ShuttleScored = false;
    }

    IEnumerator Launch()
    {

        rb.velocity = new Vector2(0, 0);

        timeleft -= Time.deltaTime;

        if (timeleft < 0)
        {
            timeleft = rotationTime;
        }

        if (timeleft > 0)
        {
            gameObject.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed * 360);
        }

        yield return new WaitForSecondsRealtime(WaitForRotation);


        float x = Random.Range(0, 2) == 0 ? -4 : 4;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);

        if (ResetShuttle == false && ShuttleReset == false)
        {
            ShuttleScored = false;
        }

    }

    private void Update()
    {
        ResetShuttle = GameObject.Find("ShuttleCatchP1").GetComponent<ScoreboardP1>().ResetShuttle;
        ShuttleReset = GameObject.Find("ShuttleCatchP2").GetComponent<ScoreboardP2>().ShuttleReset;

        if (ResetShuttle == true | ShuttleReset == true)
        {
            transform.position = new Vector2(0, 0);
            ShuttleScored = true;
            StartCoroutine(Launch());
        }

    }


}
