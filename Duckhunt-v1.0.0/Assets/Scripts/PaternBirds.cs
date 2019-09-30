using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaternBirds : MonoBehaviour
{


    public float speed = .05f;
    public bool direction = true;
    public GameObject Duck;
    float randX;
    Vector3 whereToSpawn;
    public float spawnrate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        ResetDirection();
    }


    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnrate;
            randX = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector3(randX, transform.position.y);
            Instantiate(Duck, whereToSpawn, Quaternion.identity);
        }
        if (direction)
        {
            transform.position += new Vector3(speed, speed);
        }
        else
        {
            transform.position += new Vector3(speed * -1, speed);
        }
    }
    public Vector3 Center;
    public Vector3 size;


    void OnTriggerEnter2D()
    {
        ResetDirection();
    }

    void ResetDirection()
    {
        direction = (Random.value < .5);
    }
}
