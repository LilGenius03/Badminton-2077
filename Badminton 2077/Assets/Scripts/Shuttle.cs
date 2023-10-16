using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shuttle : MonoBehaviour
{
    public float speed;
    public float decel;
    public float rotationSpeed = 1f;
    public float rotationTime = 2f;
    public float WaitForRotation = 3f;
    public float timeleft;
    public bool ShuttleReset;
    public bool ShuttleScored;
    public Vector3[] dest = new Vector3[15];
    public bool change = false;

    public int target = 0;

    int p1Score = 0;
    int p2Score = 0;

    public Text score1;
    public Text score2;

    private void FixedUpdate()
    {
        score1.text = p1Score.ToString();
        score2.text = p2Score.ToString();

        if (change && transform.position.x <= 0.1&& transform.position.x >= -0.1)
        {
            target++;
            change = false;
        }
        if (ShuttleReset)
        {
            Launch();
        }
        else if(!ShuttleReset)
        {
            Move();
        }
        if(transform.position == dest[target]||speed <= 0)
        {
            if(target == 1||target == 7|| target >=9 && target <=13)
            {
                p2Score++;
            }
            else if (target == 8 || target == 14 || target >= 2 && target <= 6)
            {
                p1Score++;
            }
            ShuttleReset = true;

        }

        EndGame();
    }

    void Move()
    {
        if (speed > 0 && transform.position != dest[target])
        {
            speed -= decel;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, dest[target], step);
        }
    }

    void Launch()
    {
        timeleft -= Time.deltaTime;
        target = 0;
        transform.position = dest[0];
        if (timeleft < 0)
        {
            timeleft = rotationTime;
            ShuttleReset = false;
            speed = 10;
            target = (Random.Range(1, 14));
            if(target == 7|| target == 8)
            {
                target -= 2;
            }
        }

        if (timeleft > 0)
        {
            gameObject.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed * 360);
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
