using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Assets.Scripts;

public class poinitScript : MonoBehaviour
{

    public Text pointText;
    public int points;
    int highScore;
    SaveGame saveGame;

    // Start is called before the first frame update
    void Start()
    {
        saveGame = new SaveGame();
        points = 0;
        saveGame.LoadPoints();
        highScore = saveGame.HigeScore;
        
        pointText.text = string.Format("HighScore: {0} \nPoints: 0", highScore.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        saveGame.HigeScore = this.highScore;
        pointText.text = string.Format("HighScore: {0} \nPoints: {1}", highScore.ToString(), points.ToString());

        if (points > highScore)
        {
            highScore = points;
            saveGame.HigeScore = highScore;
        }
    }

    public void SavePoints()
    {
        saveGame.SavePoints();
    }

    public void LoadPoints()
    {
        saveGame.LoadPoints();
    }
}
