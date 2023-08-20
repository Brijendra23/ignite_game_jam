using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb; // this is how you declare rigidbody variable
    public float speed;
    public float force_up = 1000f;
    public bool isGrounded = true;
    public float gravityModifier;
    public Animator playerAnim;
    private bool left=false, middle=true, right=false,transit=false;

    public bool hasDied = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // just to get user input from wasd or arrow keys

        Vector3 player_position = transform.position;
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (left)
             {
                 player_position.x = 0;
                 middle = true;
                 left = false;
             }
             else if (middle)
             {
                 player_position.x = 10;
                 right = true;
                 middle = false;
             }
            

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (right)
             {
                 player_position.x = 0;
                 middle = true;
                 right = false;
             }
             else if (middle)
             {
                 player_position.x = -10;
                 left = true;
                 middle = false;
             }
            
        }
        player_position.z += Time.deltaTime * speed;
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector3.up*force_up,ForceMode.Impulse) ;
                isGrounded = false;
                playerAnim.SetTrigger("Jump_trig");
            }
        }

        transform.position = player_position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
