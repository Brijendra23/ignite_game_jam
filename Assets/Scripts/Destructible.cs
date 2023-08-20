using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    [SerializeField] private GameObject destroyedVersion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Destroyed()
    {
      Instantiate(destroyedVersion, transform.position,transform.rotation);
      Destroy(gameObject);
    }

}
