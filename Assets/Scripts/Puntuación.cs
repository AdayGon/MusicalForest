using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuaci�n:MonoBehaviour

 { 
private int score;
public TextMeshProUGUI scoreText;
void Start()
{ 

    score = 0;
    scoreText.text = "Score: " + score;
}
}
