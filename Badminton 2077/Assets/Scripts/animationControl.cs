using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControl : MonoBehaviour
{
    public Animator anim;
    //public bool IsHitting = false;

    public KeyCode A;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(A))
        {
            //IsHitting = true;
            anim.Play("Player 1 Top Hand Swing Animation");
        }
        else if (Input.GetKeyUp(A))
        {
            anim.Play("Player 1 Top Hand Neutral Animation");
        }
            
    }
}
