using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour
{
    public GameObject Button;
    public GameObject background;
    public bool gameEnds;

    float ScreenX;

    // Start is called before the first frame update
    void Start()
    {
        gameEnds = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnds)
        {
            if (Input.GetMouseButtonDown(0) && FindObjectOfType<StartGameScript>())
            {
                ScreenX = 1000f;
                Button.transform.position = new Vector3(ScreenX, Button.transform.position.y, Button.transform.position.z);
                background.transform.position = new Vector3(ScreenX, background.transform.position.y, background.transform.position.z);

                FindObjectOfType<DuckSpawnerScript>().gameEnds = false;
            }
        }
    }

    private void ShowBeginScreen()
    {
        ScreenX = 0f;
        Button.transform.position = new Vector3(ScreenX, Button.transform.position.y, Button.transform.position.z);
        background.transform.position = new Vector3(ScreenX, background.transform.position.y, background.transform.position.z);

        FindObjectOfType<DuckSpawnerScript>().gameEnds = true;
    }
}
