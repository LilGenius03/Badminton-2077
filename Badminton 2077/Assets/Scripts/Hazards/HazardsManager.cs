using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsManager : MonoBehaviour
{
    public int[] position;
    public GameObject[] hazards;
    public GameObject ShuttleCatchP1;
    public ScoreboardP1 scoreboardP1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        scoreboardP1 = ShuttleCatchP1.GetComponent<ScoreboardP1>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if (scoreboardP1.Scored == true)
        {
            int randomIndux = Random.Range(0, hazards.Length);
            int randPos = Random.Range(0, position.Length);
            Vector2 randomSpawnPos = new Vector2(0, position[randPos]);

            Instantiate(hazards[randomIndux], randomSpawnPos, Quaternion.identity);

            scoreboardP1.Scored = false;
        }

        
           
        
            
            
      
        
        
        
      
    }
}
