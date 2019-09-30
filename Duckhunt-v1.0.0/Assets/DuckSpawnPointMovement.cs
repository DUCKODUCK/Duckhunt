using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawnPointMovement : MonoBehaviour
{
    int screenWitdh;
    float movementSpeed;
    float duckPositionX;
    string direction;

    // Start is called before the first frame update
    void Start()
    {
        screenWitdh = Screen.width;
        movementSpeed = 1f;
        direction = "right";
    }

    // Update is called once per frame
    void Update()
    {
        duckPositionX = DuckSpawnPoint.position.X;

        if (duckPositionX == screenWitdh)
        {
            direction = "left";
        }
        else if (duckPositionX == 0f)
        {
            direction = "right";
        }

        if (direction == "right")
        {
            DuckSpawnPoint.position.X = 0;
            DuckSpawnPoint.position.X = DuckSpawnPoint.position.X + movementSpeed;
        }
        else if (direction == "left")
        {
            DuckSpawnPoint.position.X = 0;
            DuckSpawnPoint.position.X = DuckSpawnPoint.position.X - movementSpeed;
        }
    }
}
