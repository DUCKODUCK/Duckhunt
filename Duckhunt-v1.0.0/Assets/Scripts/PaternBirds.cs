using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaternBirds : MonoBehaviour
{
    public float speed = .05f;
    public bool direction = true;
    public Collider2D duckCollider;
    // Start is called before the first frame update
    void Start()
    {
        ResetDirection();
        duckCollider = GetComponent<Collider2D>();
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
    public Vector3 Center;
    public Vector3 size;


    void OnTriggerStay2D(Collider2D other)
    {
        if(other.GetComponent<Collider>().GetComponent<bindToMouse>())
        {
            Debug.Log("Contact");
        }
        ResetDirection();
    }

    void ResetDirection()
    {
        direction = (Random.value < .5);
    }

}
