using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour
{
    public int bullets;
  /*  public AudioClip laugh;*/
    public int test;
    public AudioSource audioSource;
    public AudioClip laugh;

    // Start is called before the first frame update
    void Start()
    {
        bullets = 3;
        Debug.Log("bullets in mouseklick ivent" + bullets.ToString());
        audioSource = GetComponent<AudioSource>();
   ;
        //this.GetComponent<AudioSource>().clip = laugh;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {
            audioSource.clip = laugh;
            audioSource.Play();
            try
            {
                if (bullets > 0)
                {

                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider.GetComponent<PaternBirds>())
                {
                    FindObjectOfType<poinitScript>().points++;
                    Destroy(hit.collider.GetComponent<PaternBirds>().gameObject);
                    }
                }
                else
                {

                }
            }
            catch (System.NullReferenceException)
            {
                Debug.Log("Did not hit something");
                this.gameObject.AddComponent<AudioSource>();
                 this.GetComponent<AudioSource>().clip = laugh;
                  this.GetComponent<AudioSource>().Play();
                audioSource.clip = laugh;
               audioSource.Play();
                audioSource.mute = !audioSource.mute;
            }
        }
    }
}
