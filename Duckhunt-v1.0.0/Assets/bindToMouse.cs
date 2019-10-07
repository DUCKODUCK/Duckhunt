using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bindToMouse : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    // Start is called before the first frame update
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( Input.mousePosition.x, Input.mousePosition.y, 0);
       // Debug.Log(transform.position);
    }

 
}
