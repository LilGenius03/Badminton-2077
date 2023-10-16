using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsManager : MonoBehaviour
{
    public int[] position;
    public GameObject[] hazards;
    public Shuttle shuttle;
    public GameObject Shuttle;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        shuttle = Shuttle.GetComponent<Shuttle>();
        
    }

    // Update is called once per frame
    void Update()
    {

           if(shuttle.ShuttleReset == true)
           {
             int randomIndux = Random.Range(0, hazards.Length);
             int randPos = Random.Range(0, position.Length);
             Vector2 randomSpawnPos = new Vector2(0, position[randPos]);

             Instantiate(hazards[randomIndux], randomSpawnPos, Quaternion.identity);
           }

        
      
    }
}
