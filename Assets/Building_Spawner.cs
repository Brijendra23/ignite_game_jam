using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] building;
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
        float zPos = 0; float xPos = 0;

        while (xPos != 1000)// using the player in the scene
        {
            int buildingIndex = Random.Range(0, building.Length);
            int buildingIndex2= Random.Range(0, building.Length);
            Vector3 posX = new Vector3(xPos , 0.0f, zPos);
            Vector3 posZ = new Vector3(xPos , 0.0f, zPos + 50);

            Instantiate(building[buildingIndex], posZ, Quaternion.Euler(0,180,0));
            Instantiate(building[buildingIndex2], posX, building[buildingIndex].transform.rotation);
            xPos= xPos + 20;

            // use tag and player position to delete the extra passed buildings
        }
    }
}
