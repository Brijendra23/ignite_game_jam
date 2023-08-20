using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Building_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] building;
    [SerializeField] private GameObject player;
    
    private Vector3 spawnPos=new Vector3(-30.0f,0.0f,50.0f); 
    private Vector3 spawnPos2 = new Vector3(30.0f, 0.0f, 50.0f);

    void Start()
    {
        InvokeRepeating("buildingSpawner", 0, 3);
        InvokeRepeating("buildingDestroyer", 5, 1);

    }

    // Update is called once per frame
    void Update()
    {

    } 
    void buildingSpawner()
    {
        int buildingIndex1= Random.Range(0,building.Length);
        int buildingIndex2= Random.Range(0,building.Length);


        Instantiate(building[buildingIndex1],spawnPos,Quaternion.Euler(0,90,0));
        Instantiate(building[buildingIndex2], spawnPos2, Quaternion.Euler(0,-90 , 0));

        
    }

    void buildingDestroyer()
    {
        GameObject[] build = GameObject.FindGameObjectsWithTag("Building");
        foreach (GameObject go in build)
        {
            if (go.transform.position.z < (-50.0f))
            {
                Destroy(go);
            }
        }

    }

}
