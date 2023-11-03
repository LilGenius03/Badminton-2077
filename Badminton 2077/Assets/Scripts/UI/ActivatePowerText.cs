using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivatePowerText : MonoBehaviour
{
    bool PowerSelectText;

    public TextMeshProUGUI ShowText;

    void Start()
    {
        ShowText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        /*PowerSelectText = GameObject.Find("Scripts").GetComponent<SelectRacket>().PowerSelect;

        if (PowerSelectText == true)
        {
            ShowText.enabled = true;
        }

        if (PowerSelectText == false)
        {
            ShowText.enabled = false;
        }*/
    }
}
