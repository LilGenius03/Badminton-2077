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
    float timeleft;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotationMode());
        Launch();
    }

    IEnumerator RotationMode()
    {
        yield return new WaitForSeconds(rotationTime);

        timeleft -= Time.deltaTime;

        if (timeleft < 0)
        {
            timeleft = rotationTime;
        }

        if (timeleft > 0)
        {
            gameObject.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed * 360);
        }
        
    }
   

   private void Launch()
   {
       

        float x = Random.Range(0, 2) == 0 ? -4 : 4;
        float y = Random.Range(0, 2) == 0  ? -4 : 4 ;
        rb.velocity = new Vector2 (speed * x , speed * y );
   }
}
