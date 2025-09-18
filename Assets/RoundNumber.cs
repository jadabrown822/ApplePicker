using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundNumber : MonoBehaviour
{
    public TextMeshProUGUI roundText;

    public int currentRound;

    public float timeToNextRound = 45.0f;

    public const int maxRound = 4;
    
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateRoundText();

        StartCoroutine(IncreaseRoundOverTime());
    }


    void UpdateRoundText()
    {
        roundText.text = "Round " + currentRound.ToString("#,0");
    }


    private IEnumerator IncreaseRoundOverTime()
    {
        while (currentRound < maxRound)
        {
            yield return new WaitForSeconds(timeToNextRound);

            currentRound++;

            UpdateRoundText();
        }
    }

    /*
        // Update is called once per frame
        void Update()
        {
        
        }
    */
    
}
