using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundNumber : MonoBehaviour
{
    [Header("Dynamic")]

    public TextMeshProUGUI roundText;

    private int currentRound = 1;

    public float timeToNextRound = 1.0f;


    private void start() 
    {
        UpdateRoundText();
        StartCoroutine(IncreaseRoundOverTime());
    }


    private void UpdateRoundText() 
    {
        roundText.text = "Round " + currentRound.ToString("#,0");
    }


    private IEnumerator IncreaseRoundOverTime()
    {
        while (currentRound < 4)
        {
            yield return new WaitForSeconds(timeToNextRound);

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
