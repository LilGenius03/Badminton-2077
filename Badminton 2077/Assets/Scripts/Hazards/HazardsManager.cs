using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsManager : MonoBehaviour
{
    public int[] position;
    public GameObject[] hazards;
    public GameObject PortalParent;
    public float timeleft = 10f;
    public float ResetTime = 5f;


    private void Start()
    {
        PortalParent = this.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;

        

        if (timeleft < 0)
        {
            GameObject nearestHazard = GameObject.FindWithTag("Hazard");

            if (nearestHazard != null)
            {
                Destroy(nearestHazard);
            }

            timeleft = ResetTime;

            int randomIndux = Random.Range(0, hazards.Length);
            int randPos = Random.Range(0, position.Length);
            Vector2 randomSpawnPos = new Vector2(0, position[randPos]);

            Instantiate(hazards[randomIndux], randomSpawnPos, Quaternion.identity);

            

            
        }
             

      
    }
}
