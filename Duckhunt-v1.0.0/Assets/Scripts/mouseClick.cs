using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour
{
    
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            try
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider.GetComponent<PaternBirds>())
                {
                    FindObjectOfType<poinitScript>().points++;
                    Destroy(hit.collider.GetComponent<PaternBirds>().gameObject);
                }
            }
            catch (System.NullReferenceException)
            {
                Debug.Log("Did not hit something");
            }
        }
    }
}
