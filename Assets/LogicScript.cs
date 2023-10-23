using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text componentini kullanabilmek için ekledik.

public class LogicScript : MonoBehaviour
{
    public float playerScore;
    public Text scoreText;

    [ContextMenu("Scoru arttır")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }


}
