using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaternBirds : MonoBehaviour
{
    public float speed = .05f;
    public bool direction = true;
    public Collider2D duckCollider;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        ResetDirection();
        duckCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {


        if (direction)
        {
            transform.position += new Vector3(speed, speed);
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
            transform.position += new Vector3(speed * -1, speed);
        }
        if(transform.position.x>9)
        {
            transform.position = new Vector3(8, transform.position.y, transform.position.z);
            if (direction)
            {
                direction = false;
            }
            else
            {
                if (!direction)
                {
                    direction = true;
                }
            }
        }
        if (transform.position.x < -9)
        {
             transform.position = new Vector3(-8, transform.position.y, transform.position.z);
            if (direction)
            {
                direction = false;
            }
            else
            {
                if (!direction)
                {
                    direction = true;
                }
            }
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
