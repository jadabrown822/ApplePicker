using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // need this line for uGUI to work
using TMPro;

public class HighScore : MonoBehaviour
{
    static private TextMeshProUGUI _UI_TEXT;
    static private int _SCORE = 1000;

    private TextMeshProUGUI txtCom; // txtCom is  a reference to this GO's Text component


    void Awake()
    {
        _UI_TEXT = GetComponent<TextMeshProUGUI>();
    }


    static public int SCORE
    {
        get { return _SCORE; }
        private set
        {
            _SCORE = value;
            if (_UI_TEXT != null)
            {
                _UI_TEXT.text = "High Score: " + value.ToString("#,0");
            }
        }
    }


    static public void TRY_SET_HIGH_SCORE(int scoreToTry)
    {
        if (scoreToTry <= SCORE) return;    // If scoreToTry us too low, return
        SCORE = scoreToTry;
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
