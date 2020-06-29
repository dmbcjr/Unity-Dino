using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI hiScore_Text;
    public TextMeshProUGUI currentScore_Text;
    public Transform playerDistance;

    float hiScore, cScore;


    void Start()
    {
        

        hiScore = 0;
        cScore = 0;
    }

    void Update()
    {
        TrackScore();    
    }

    private void TrackScore()
    {
        cScore = playerDistance.position.x;

        SetCurrentScore();

       
    }

    private void SetCurrentScore ()
    {

        currentScore_Text.text = Mathf.Round(cScore).ToString("00000");
        
       
    }
    
    public void SetHighScore ()
    {
        if (cScore > hiScore)
        {
            hiScore = cScore;
            hiScore_Text.text = Mathf.Round(cScore).ToString("00000");
        }
        
        
    }
}
