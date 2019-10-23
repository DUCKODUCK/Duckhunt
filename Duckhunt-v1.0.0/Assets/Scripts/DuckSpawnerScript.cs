using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuckSpawnerScript : MonoBehaviour
{
    public GameObject Duck;
    Vector3 whereToSpawn;
    public float spawnrate = 2.5f;
    float randX;
    float nextSpawn = 2f;
    public float currentTime;
    bool spawnBird;
    public uint spawnCounter;
    public int numberOfDucks;

    public int levelRounds = 3;
    public Text roundText;
    int levelCounter;
    int roundCounter;
    public int points;
    public int hittedDucksInRound;

    public bool timerActive;
    public float timeStart;
    public Text endScreenText;

    public bool gameEnds;
    public float globalBirdSpeed;

    // Start is called before the first frame update
    void Start()
    {
        gameEnds = true;
        roundCounter = 1;
        levelCounter = 1;
        hittedDucksInRound = 0;

        LabelUpdate();
        points = FindObjectOfType<poinitScript>().points;
        timeStart = 5f;
        levelCounter = 1;
        roundCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameEnds)
        {
            points = FindObjectOfType<poinitScript>().points;
            numberOfDucks = GameObject.FindObjectsOfType<PaternBirds>().Length;

            if (!timerActive)
            {
                if (currentTime < nextSpawn)
                {
                    currentTime += 1.0f * Time.deltaTime;
                    spawnBird = false;
                }
                else
                {
                    currentTime = 0f;
                    if (spawnCounter < 2)
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
                    spawnBird = false;

                    if (Input.GetButton("Fire1"))
                    {
                        Destroy(this.gameObject);
                    }
                }
            }
            else if (timerActive)
            {
                timeStart -= Time.deltaTime;
                Debug.Log("Timer is aan | " + timeStart.ToString());
                if (timeStart <= 0f)
                {
                    levelCounter++;
                    globalBirdSpeed += 0.5f;

                    FindObjectOfType<mouseClick>().bullets = 3;
                    roundCounter = 1;
                    //FindObjectOfType<poinitScript>().SavePoints();
                    timeStart = 5f;
                    timerActive = false;
                    spawnBird = true;
                    endScreenText.text = "";
                    spawnCounter = 0;
                    hittedDucksInRound = 0;
                    Debug.Log("timer off");
                    LabelUpdate();
                }
            }
            else
            {
                Debug.Log("Timer is aan | " + timeStart.ToString());
            }
        }
        else
        {
            if (timerActive)
            {
                if (timeStart <= 0f)
                {
                    ResetGame();
                    FindObjectOfType<StartGameScript>().gameEnds = true;
                    gameEnds = true;
                }
            }
        }
    }

    private void NextRound()
     {
        //if statment om te checken of alle vogels destoryd zijn
        // is dat niet zo destroy alle vogels

        //play animation

        if (roundCounter == levelRounds)
        {
            string endScreenTextMessage = "Je bent bij het einde van het level.";
            if (hittedDucksInRound >= 4)
            {
                endScreenText.text += string.Format("{0} Je hebt genoeg Punten Gehaald.\n\n Je hebt {1} Eenden geraakt", endScreenTextMessage, hittedDucksInRound.ToString());
                timerActive = true;
            }
            else
            {
                endScreenText.text += string.Format("{0} Niet genoeg punten gehaald, game over!\n\n Je hebt {1}/6 Eenden geraakt", endScreenTextMessage, hittedDucksInRound.ToString());
                gameEnds = true;
            }
        }
        else
        {
            spawnCounter = 0;
            roundCounter++;
            FindObjectOfType<mouseClick>().bullets = 3;
            LabelUpdate();
        }
    }

    private void LabelUpdate()
    {
        roundText.text = string.Format("Ronde: {0} | Level: {1}", roundCounter.ToString(), levelCounter.ToString());
    }

    private void ResetGame()
    {
        FindObjectOfType<mouseClick>().bullets = 3;
        roundCounter = 1;
        timeStart = 5f;
        timerActive = false;
        spawnBird = true;
        endScreenText.text = "";
        spawnCounter = 0;
        hittedDucksInRound = 0;

        //find out how to show begin screen!!
        //FindObjectOfType<StartGameScript>()
    }
}

