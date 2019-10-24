using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour
{
    public GameObject Button;
    public GameObject background;
    public DuckSpawnerScript duckSpawnerScript;

    public float ScreenX;

    // Start is called before the first frame update
    void Start()
    {
        duckSpawnerScript = FindObjectOfType<DuckSpawnerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (duckSpawnerScript.gameEnds)
        {
            if (Input.GetMouseButtonDown(0) && FindObjectOfType<StartGameScript>())
            {
                ScreenX = 1000f;
                Button.transform.position = new Vector3(ScreenX, Button.transform.position.y, Button.transform.position.z);
                background.transform.position = new Vector3(ScreenX, background.transform.position.y, background.transform.position.z);
                duckSpawnerScript.gameEnds = false;
                FindObjectOfType<mouseClick>().bullets = 3;
            }
        }
    }

    public void ShowBeginScreen()
    {
        ScreenX = 10f;
        Button.transform.position = new Vector3(ScreenX, Button.transform.position.y, Button.transform.position.z);
        background.transform.position = new Vector3(ScreenX, background.transform.position.y, background.transform.position.z);

        FindObjectOfType<DuckSpawnerScript>().gameEnds = true;
    }
}
