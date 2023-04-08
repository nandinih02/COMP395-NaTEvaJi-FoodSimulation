using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
   
   public int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = ScoreStatic.score.ToString();
    }
             

    void Update()
    {
        UpdateScore();
    }


    private void UpdateScore()
    {
        score = ScoreStatic.score;
        scoreText.text = $"Score: {score}";
    }

    
}
