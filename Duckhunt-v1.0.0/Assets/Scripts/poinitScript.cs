using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class poinitScript : MonoBehaviour
{

    public Text pointText;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        pointText.text = "Points: 0";
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + points.ToString();
    }

    public void SavePoints()
    {
        //zet punten in .json
        //opslaan in file

        var json = JsonConvert.SerializeObject(points);
        var path = Path.Combine(Application.dataPath, "points.json");
        File.WriteAllText(path, json);
    }

    public void LoadPoints()
    {
        var path = Path.Combine(Application.dataPath, "points.json");
        //lees file
        //umzetten van .json naar int
        var fileContent = File.ReadAllText(path);
        var accountsFromFile = JsonConvert.DeserializeObject(fileContent);
        var reSerializedJson = JsonConvert.SerializeObject(accountsFromFile);
    }
}
