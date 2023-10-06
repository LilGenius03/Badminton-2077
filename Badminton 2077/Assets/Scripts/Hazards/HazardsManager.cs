using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsManager : MonoBehaviour
{
    public int[] position;
    public GameObject[] hazards;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      if(Input.GetKeyDown(KeyCode.Space))
      {
            int randomIndux = Random.Range(0, hazards.Length);
            int randPos = Random.Range(0, position.Length);
            Vector2 randomSpawnPos = new Vector2(0, position[randPos]);

            Instantiate(hazards[randomIndux], randomSpawnPos, Quaternion.identity);
      }
        
        
        
      
    }
}
