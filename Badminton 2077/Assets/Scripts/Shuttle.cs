using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class Shuttle : MonoBehaviour
{
    public float speed;
    public float decel;
    public float rotationSpeed = 1f;
    public float rotationTime = 2f;
    public float timeleft;
    public float WaitTillLaunch = 1f;
    public bool ShuttleReset;
    public bool ShuttleScored;
    public Vector3[] dest = new Vector3[15];
    public bool change = false;
    public int upDown = 0;
    //public ParticleSystem ShuttleHit;
 
    public int target = 0;

    public GameObject point;
    float wait = 0.2f;

    int p1Score = 0;
    int p2Score = 0;

    public Text score1;
    public Text score2;

    public GameObject hazardManag;

    private void FixedUpdate()
    {
        Vector2 direction = dest[target] - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.back * angle);
        score1.text = p1Score.ToString();
        score2.text = p2Score.ToString();

        if (change && transform.position.x <= 0.1&& transform.position.x >= -0.1)
        {
            target += upDown;
            change = false;
        }
        if(target >= 16)
        {
            target = 15;
        }
        else if(target <= 0)
        {
            target = 1;
        }
        if (ShuttleReset)
        {
            point.SetActive(true);
            Launch();
        }
        else if(!ShuttleReset)
        {
            point.SetActive(false);
            Move();
        }
        if(transform.position == dest[target])
        {
            if(target == 1||target == 7|| target >=9 && target <=13)
            {
                p2Score++;
                ShuttleScored = true;
            }
            else if (target == 8 || target == 14 || target >= 2 && target <= 6)
            {
                p1Score++;
                ShuttleScored = true;
            }
            ShuttleReset = true;
        }

        EndGame();
    }

    void Move()
    {
        if (transform.position != dest[target])
        {
            //ShuttleHit.Play();
            if(speed > 1)
            {
                speed -= decel;
            }
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, dest[target], step);
        }
    }

    void Launch()
    {
        hazardManag.GetComponent<HazardsManager>().FullReset();
        timeleft -= Time.deltaTime;
        transform.position = dest[0];

        if (timeleft > 1f)
        {
            if (wait <= 0)
            {
                do
                {
                    target = (Random.Range(2, 14));
                }
                while (target == 7 || target == 8);
                point.transform.position = dest[target];
                wait = 0.2f;
            }
            wait -= Time.deltaTime;
        }
        else if (timeleft < 0)
        {
            timeleft = rotationTime;
            ShuttleReset = false;
            speed = 10;
        }
    }

    void EndGame()
    {
        if(p1Score > p2Score + 1 && p1Score == 11)
        {
            SceneManager.LoadScene("Victory1");
        }

        else if(p2Score > p1Score + 1 && p2Score == 11)
        {
            SceneManager.LoadScene("Victory2");
        }
    }


}
