using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float gridSize = 1f;
    private float x, y;

    public GameObject player2Sprite;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool uparrow = Input.GetKeyDown(KeyCode.UpArrow);
        bool downarrow = Input.GetKeyDown(KeyCode.DownArrow);

        if (uparrow)
        {
            y = gridSize;
        }
        if (downarrow)
        {
            y = -gridSize;
        }
        transform.Translate(x, y, 0);
        x = 0;
        y = 0;
    }
}
