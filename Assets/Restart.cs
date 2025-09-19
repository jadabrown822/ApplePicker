using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Restart : MonoBehaviour
{
    public string gameSceneName = "_Scene_0";
    public Button restartGameButton;

    [Header("Hover Colors")]
    public Color normalColor = Color.white;
    public Color hoverColor = Color.red;
    public Color pressedColor = Color.gray;

    // Start is called before the first frame update
    void Start()
    {
        restartGameButton.onClick.AddListener(RestartGame);

        SetupButtonColors(restartGameButton);
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }


    private void SetupButtonColors(Button button)
    {
        TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

        // If the button has a TextMeshPro child, set its target graphic.
        if (buttonText != null)
        {
            // Set the target graphic for the button's color tint transition to be the text itself
            button.targetGraphic = buttonText;

            // Set the transition colors
            ColorBlock cb = button.colors;
            cb.normalColor = normalColor;
            cb.highlightedColor = hoverColor;
            cb.pressedColor = pressedColor;
            button.colors = cb;

            // Set the transition mode to Colot Tint
            button.transition = Selectable.Transition.ColorTint;
        }
    }

    /*
        // Update is called once per frame
        void Update()
        {
        
        }
    */
}
