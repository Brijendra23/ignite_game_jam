using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public GameObject explosion;
    public Vector3 pos = new Vector3(41, 1.9f, 0.4f);
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
        if (other.tag == "grenade")
        {
            StartCoroutine(Death());
            Instantiate(explosion, pos, transform.rotation);
            gameObject.GetComponent<Animator>().SetBool("Death_b", true);
            gameObject.GetComponent<Animator>().SetInteger("DeathType_int", 2);
        }
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
