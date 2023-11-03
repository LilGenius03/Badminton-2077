using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateRocket : MonoBehaviour
{
    public Image rend;

    bool RocketSelect;

    private void Start()
    {
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*RocketSelect = GameObject.Find("Scripts").GetComponent<SelectRacket>().RocketSelect;

        if (RocketSelect == true)
        {
            rend.enabled = true;
        }

        if (RocketSelect == false)
        {
            rend.enabled = false;
        }*/
    }
}
