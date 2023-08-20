using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] building;
    [SerializeField] private GameObject player;
    private bool playerHasDied;
    
    void Start()
    {
        InvokeRepeating("buildingSpawner", 0, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {

    } 
    void buildingSpawner()
    {
       
        Instantiate(building);











           
     }
    
}
