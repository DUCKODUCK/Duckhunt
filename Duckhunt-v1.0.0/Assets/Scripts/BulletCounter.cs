using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
    public Text bulletText;
    public int bullets;
    // Start is called before the first frame update
    void Start()
    {
        bullets = 3;
    }

    // Update is called once per frame
    void Update()
    {
        bulletText.text = "Bullets:" + bullets;

        if (Input.GetMouseButtonDown(0))
        {
            if (!(bullets <= 0))
            {
                bullets--;
            }
        }
        
    }
}
