using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patern : MonoBehaviour
{
    public float speed;
    public bool direction = true;


    void Start()
    {
        ResetDirection();
        speed = .05f;
    }

    void Update()
    {

        if (direction)
        {
            transform.position += new Vector3(speed, speed);
        }
        else
        {
            transform.position += new Vector3(speed * -1, speed);
        }
    }

    void OnTriggerEnter2D()
    {
        ResetDirection();
    }

    void ResetDirection()
    {
        direction = (Random.value < .5);
    }
}