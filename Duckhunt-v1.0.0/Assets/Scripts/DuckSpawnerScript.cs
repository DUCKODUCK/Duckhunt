using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuckSpawnerScript : MonoBehaviour
{


    public int levelRounds = 3;
    public GameObject Duck;
    float randX;
    Vector3 whereToSpawn;
    public float spawnrate = 2.5f;
    float nextSpawn = 2f;
    public float currentTime;
    bool spawnBird;
    public uint spawnCounter;
    uint spawnCounterToText = 1;
    public int numberOfDucks;
    public Text roundText;
    public int pointsPerLevel;
    bool endOfLevel;
    public Text endScreenText;
    
 
    // Start is called before the first frame update
    void Start()
    {
        roundText.text = spawnCounterToText.ToString();
        pointsPerLevel = FindObjectOfType<poinitScript>().points;
    }

    // Update is called once per frame
    void Update()
    {
        pointsPerLevel = FindObjectOfType<poinitScript>().points;
        numberOfDucks = GameObject.FindObjectsOfType<PaternBirds>().Length;

        if (currentTime < nextSpawn)
        {
            currentTime += 1.0f * Time.deltaTime;
            spawnBird = false;
        }
        else
        {
            currentTime = 0f;
            if (spawnCounter < 2 && endOfLevel == false)
            {
                spawnBird = true;
                spawnCounter++;
            }
            else
            {
              
                if (numberOfDucks == 0)
                {
                    NextRound();
                }
            }
        }
        if (spawnBird)
        {

            randX = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector3(randX, transform.position.y);
            GameObject clone = Instantiate(Duck, whereToSpawn, Quaternion.identity);
            //clone.MarkAsClone();
            spawnBird = false;

            if(Input.GetButton("Fire1"))
            {
                Destroy(this.gameObject);
            }

           
        }
    }

    void OnMouseDown()
    {
            // Destroy game object
           // Destroy(this.gameObject);
    }

    private void NextRound()
    {
        //if statment om te checken of alle vogels destoryd zijn
        // is dat niet zo destroy alle vogels

        //play animation

        if (spawnCounterToText == levelRounds)
        {
            endScreenText.text = "Je bent bij het einde van het level. ";
            Debug.Log("end of level");
            if (pointsPerLevel >= 4)
            {
                Debug.Log("genoeg points gehaald");
                endScreenText.text += "Je hebt genoeg Punten Gehaald";
            }
            else
            {
                endScreenText.text += "Niet behaald";
            }
            spawnBird = false;
            endOfLevel = true;
        }
        else
        {
            endOfLevel = false;
            spawnCounterToText++;
            spawnCounter = 0;
            roundText.text = spawnCounterToText.ToString();
            FindObjectOfType<mouseClick>().bullets = 3;
        }

    }
}

