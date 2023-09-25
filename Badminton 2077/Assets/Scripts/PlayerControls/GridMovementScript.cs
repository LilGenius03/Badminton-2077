using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovementScript : MonoBehaviour
{
    public float gridSize = 1f;
    private float x, y;

    public GameObject playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool w = Input.GetKeyDown(KeyCode.W);
        bool s = Input.GetKeyDown(KeyCode.S);

        if (w)
        {
            y = gridSize;
        }
        if (s)
        {
            y = -gridSize;
        }
        transform.Translate(x, y, 0);
        x = 0;
        y = 0;
    }
}
