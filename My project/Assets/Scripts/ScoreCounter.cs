using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreCounter : MonoBehaviour
{
    public static int ScoreValueRed = 0;  
    public Text scoreRed;
    public Text scoreGreen; 
    // Start is called before the first frame update
    void Start()
    {
        scoreRed = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreRed.text = "Red hits: " + ScoreValueRed;
    }
}
