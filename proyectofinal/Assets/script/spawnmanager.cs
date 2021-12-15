using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    private float startTime = 1f;
    private float repeatRate = 5f;
    private float xRange = 100f;
    private float yRange = 100f;
    private float zRange = 100f;
    private float maxbajo = 50f;
    private float randomX;
    private float randomY;
    private float randomZ;
    public GameObject boom;
    private Vector3 spawnPotition;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", startTime, repeatRate);
    }

    public Vector3 RandomPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(maxbajo, yRange); 
        randomZ = Random.Range(-zRange, zRange);
        return new Vector3(randomX, randomY, randomZ  );
    }
    public void SpawnPrefab()
    {
        spawnPotition = RandomPosition();
        Instantiate(boom, spawnPotition, boom.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
