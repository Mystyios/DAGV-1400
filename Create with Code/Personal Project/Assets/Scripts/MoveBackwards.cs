using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MonoBehaviour
{
    private float speed = 30;
    private float screenBound = -15;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (transform.position.z < screenBound && (gameObject.CompareTag("Obstacle") || gameObject.CompareTag("Powerup")))
        {
            Destroy(gameObject);
        }
        
    }
}
