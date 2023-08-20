
using UnityEngine;

public class ObstacleSpwaner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacle;
    [SerializeField] private GameObject player;
    [SerializeField]private float spawnX=10f;
   
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObstacleSpawn", 3, 2);
        InvokeRepeating("obstacleDestroyer", 5, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ObstacleSpawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX,spawnX), 0.0f, 30.0f);
        int ObstacleIndex = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[ObstacleIndex],spawnPos, Quaternion.Euler(0,0,0));
        
    }
    private void obstacleDestroyer()
    {
        GameObject[] dest = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach(GameObject o in dest)
        {
            if (o.transform.position.z < -50.0f)
            {
                Destroy(o);
            }
            
        }
    }


}
