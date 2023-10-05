using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
   
   public Vector2 pos1 = new Vector2 (0, 2);
   public Vector2 pos2 = new Vector2 (0, -2);
   public float speed = 1f;

    private void Update()
    {
        transform.position = Vector2.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) +1.0f) / 2.0f);
    }


}
