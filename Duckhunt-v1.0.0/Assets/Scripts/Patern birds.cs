using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paternbirds : MonoBehaviour
{

    public float speed = .05f;
    public bool direction = true;

    // Start is called before the first frame update
    void Start()
    {
        ResetDirection();
    }

    // Update is called once per frame
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
