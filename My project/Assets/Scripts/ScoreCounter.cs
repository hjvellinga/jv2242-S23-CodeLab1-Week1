using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreCounter : MonoBehaviour
{
    public static int scoreValue = 0;

    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
       scoreText = GetComponent<Text>();
      // scoreText.text = scoreValue.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Points: " + scoreValue;
    }
}
