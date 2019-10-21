using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
    public Text bulletText;
    mouseClick mouseClick;
    // Start is called before the first frame update
    void Start()
    {
        mouseClick = FindObjectOfType<mouseClick>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletText.text = "Bullets:" + mouseClick.bullets;

        if (Input.GetMouseButtonDown(0))
        {
            if (mouseClick.bullets > 0)
            {
                mouseClick.bullets--;
            }
        }
        
    }
}
