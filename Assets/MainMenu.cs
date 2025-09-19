using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    // Public fields to connect UI elements in the Inspector
    public string gameSceneName = "_Scene_0";
    public TextMeshProUGUI ApplePicker;
    public Button startGameButton;
    public Button quitGameButton;

    [Header("Hover Colors")]
    public Color normalColor = Color.white;
    public Color hoverColor = Color.red;
    public Color pressedColor = Color.gray;

    // Start is called before the first frame update
    void Start()
    {
        // Add listeners to the buttons to call the correct function when clicked.
        // This is more robust way to assign button functionalilty from code.
        startGameButton.onClick.AddListener(StartGame);
        quitGameButton.onClick.AddListener(QuitGame);

        // Ensure the text compoonents have the correct color transistions set up.
        // Calls a helper method to handle this for both buttons.
        SetupButtonColors(startGameButton);
        SetupButtonColors(quitGameButton);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
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
