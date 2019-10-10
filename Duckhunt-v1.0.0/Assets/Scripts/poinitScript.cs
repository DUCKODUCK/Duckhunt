using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class poinitScript : MonoBehaviour
{

    public Text pointText;
   // public GameObject duck;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        pointText.text = "Points:";
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points:" + points.ToString();
    }
}
