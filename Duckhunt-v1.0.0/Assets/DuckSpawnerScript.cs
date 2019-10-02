using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawnerScript : MonoBehaviour
{
    public GameObject Duck;
    float randX;
    Vector3 whereToSpawn;
    public float spawnrate = 2.5f;
    float nextSpawn = 2f;
    public float currentTime;
    bool spawnBird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < nextSpawn)
        {
            currentTime += 1.0f * Time.deltaTime;
            spawnBird = false;
        }
        else
        {
            currentTime = 0f;
            spawnBird = true;
        }
        Debug.Log(Time.time + " " + nextSpawn + " - " + spawnrate);
        if (spawnBird)
        {


            randX = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector3(randX, transform.position.y);
            Instantiate(Duck, whereToSpawn, Quaternion.identity);
            spawnBird = false;


        }
    }
}
