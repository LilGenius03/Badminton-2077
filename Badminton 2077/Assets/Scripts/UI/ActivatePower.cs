using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivatePower : MonoBehaviour
{
    public Image rend;

    bool PowerSelect;

    private void Start()
    {
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        PowerSelect = GameObject.Find("Scripts").GetComponent<SelectRacket>();

        if (PowerSelect == true)
        {
            rend.enabled = true;
        }

        if (PowerSelect == false)
        {
            rend.enabled = false;
        }
    }
}
