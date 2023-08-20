using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    [SerializeField] private GameObject bombEffect;
    [SerializeField] private float radius;
    [SerializeField] private float force = 700f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(bombEffect,transform.position,transform.rotation);

            Collider[] colliders= Physics.OverlapSphere(transform.position, radius);

            foreach(Collider col in colliders)
            {
               
                Destructible dest= col.GetComponent<Destructible>();
                if(dest != null)
                {
                    dest.Destroyed();
                }

            }
            Collider[] collidersToMove = Physics.OverlapSphere(transform.position,radius);

            foreach(Collider colToMove in collidersToMove)
            {
                Rigidbody rb = colToMove.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(force, transform.position, radius);
                }
            }
        }
    }
}
