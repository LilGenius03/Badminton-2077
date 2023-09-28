using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public  float gridSize = 1f;
    private float x, y;
    
    private bool Racket1On = true;
    private bool Racket2On = false;
    
    

    public GameObject playerSprite;
    public GameObject Racket1;
    public GameObject Racket2;
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

        if (Input.GetKeyDown(KeyCode.D) && Racket1On == true)
        {
            Racket1On = false;
            Racket2On = true;
            Racket1.SetActive(false);
            Racket2.SetActive(true);
        }

        else if(Input.GetKeyDown(KeyCode.D) && Racket2On == true)
        {
            Racket2On = false;
            Racket1On = true;
      
            Racket2.SetActive(false);
            Racket1.SetActive(true); 
        }

    }
}
