using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
   public float speed = 10f;
   public Rigidbody rb;
   public bool isGrounded = true;
   public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontalInput, 0, verticalInput);
        

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
        }

        if(Input.GetButtonDown("Fire3"))
        {
            speed = 20f;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            player.transform.localScale = new Vector3 (1, 0.5f, 1);
        }

        player.transform.localScale = new Vector3 (1, 1, 1);
        speed = 10f;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
