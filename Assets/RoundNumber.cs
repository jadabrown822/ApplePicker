using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundNumber : MonoBehaviour
{
    public TextMeshProUGUI roundText;

    private int currentLevel = 1;

    public float timeToNextRound = 5.0f;


    private void start() 
    {
        UpdateRoundText();
        StartCoroutine(IncreaseRoundOverTime());
    }


    private void UpdateRoundText() 
    {
        roundText.text = "Round " + currentRound.ToString();
    }


    private IEnumerator IncreaseRondOverTime()
    {
        while (currentRound < 4)
        {
            yield return new WaitForSecond(timeToNextRound);

            currentRound++;
            UpdateRoundText();
        }
    }
    
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
