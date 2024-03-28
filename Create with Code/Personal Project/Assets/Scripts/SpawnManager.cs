using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject powerupPrefab;
    private Vector3 spawnPos = new Vector3(0, 2.5f, 120);
    private Vector3 spawnPos2 = new Vector3(-6, 1, 120);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnPowerup", startDelay, repeatRate);
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }

    void SpawnPowerup()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(powerupPrefab, spawnPos2, powerupPrefab.transform.rotation);
        }
    }
}
