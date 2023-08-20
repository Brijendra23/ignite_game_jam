using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] building;
    [SerializeField] private GameObject player;
    
    void Start()
    {
        buildingSpawner();


    }

    // Update is called once per frame
    void Update()
    {

    } 
    void buildingSpawner()
    {
        Vector3 zPos = new Vector3(-30.0f, 0.0f, 30.0f);
        Vector3 xPos= new Vector3 (30.0f, 0.0f, 30.0f);
        Vector3 posChange = new Vector3(0.0f, 0.0f, 40.0f);

        while (zPos.z < 1500.0f)

        {
            int buildingIndex = Random.Range(0, building.Length);
            int buildingIndex2 = Random.Range(0, building.Length);
            Instantiate(building[buildingIndex], zPos, Quaternion.Euler(0, -90, 0));
            Instantiate(building[buildingIndex], xPos, Quaternion.Euler(0, 90, 0));
            zPos.z += 40.0f;
            xPos.z += 40.0f;
        }












      /*  Vector3 z = new Vector3(0.0f, 0.0f, 20f);
        float x = 0.0f;
        while (x<1500.0f)// using the player in the scene
        {
           

            int buildingIndex = Random.Range(0, building.Length);
            int buildingIndex2= Random.Range(0, building.Length);
            Vector3 posX = new Vector3(-30f , 0.0f,20f);
            Vector3 posZ = new Vector3(+30f, 0.0f, 20f);
            Instantiate(building[buildingIndex], posZ, Quaternion.Euler(0,-90,0));
            Instantiate(building[buildingIndex2],posX, Quaternion.Euler(0, 90, 0));

            posX = posX + z;
            posZ = posZ + z;
            x = x + 20;
          
            // use tag and player position to delete the extra passed buildings
            GameObject[] build = GameObject.FindGameObjectsWithTag("Building");
            for (int i = 0; i < build.Length; i++)
            {
                if (build[i].transform.position.z < (player.transform.position.z - 10))
                {
                    Destroy(build[i]);
                }
            }*/
           
        }
    
}
