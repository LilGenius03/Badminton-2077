using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    public bool VictoryP1;
    public bool VictoryP2;


    void Update()
    {
        VictoryP1 = GameObject.Find("ShuttleCatchP1").GetComponent<ScoreboardP1>().VictoryP1;
        VictoryP2 = GameObject.Find("ShuttleCatchP2").GetComponent<ScoreboardP2>().VictoryP2;

        if (VictoryP1 == true)
        {
            SceneManager.LoadScene("Victory1");
        }

        if (VictoryP2 == true)
        {
            SceneManager.LoadScene("Victory2");
        }
    }
}
