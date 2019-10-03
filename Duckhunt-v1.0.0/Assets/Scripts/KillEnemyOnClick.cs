using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemyOnClick : MonoBehaviour
{

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Ray ray = cam.ScreenPointToRay(new Vector2(200, 200));
            //Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
            //Debug.Log(ray);
        }
    }
}
