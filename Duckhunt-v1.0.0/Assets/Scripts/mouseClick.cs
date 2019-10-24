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

    poinitScript pointsScript;
    DuckSpawnerScript duckSpawnerScript;

    // Start is called before the first frame update
    void Start()
    {
        pointsScript = FindObjectOfType<poinitScript>();
        duckSpawnerScript = FindObjectOfType<DuckSpawnerScript>();

        bullets = 3;
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

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (bullets > 0 && hit.collider != null)
            {
                if (hit.collider.GetComponent<PaternBirds>() == null)
                {
                    Debug.Log("Miss");
                    this.gameObject.AddComponent<AudioSource>();
                    this.GetComponent<AudioSource>().clip = laugh;
                    this.GetComponent<AudioSource>().Play();
                    audioSource.clip = laugh;
                    audioSource.Play();
                    audioSource.mute = !audioSource.mute;
                }
                else if (hit.collider.GetComponent<PaternBirds>())
                {
                    Debug.Log("Hitted: Duck");
                    pointsScript.points++;
                    duckSpawnerScript.hittedDucksInRound++;
                    Destroy(hit.collider.GetComponent<PaternBirds>().gameObject);
                }
            }
            
        }
    }
}
