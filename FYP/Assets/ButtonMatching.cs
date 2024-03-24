using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMatching : MonoBehaviour
{
    // public GameObject[] emotionPictures;  // Array of Image components representing the emotion pictures
    // public Button[] emotionButtons;  // Array of Button components representing the buttons for emotions
    // public Text timerText;           // Text component for displaying the timer
    // public GameObject gameOverScreen;
    // public GameObject youWonScreen;

    // private int correctMatches = 0;
    // private bool gameActive = true;
    // private float timer = 20f;
    // public GameObject Happy;
    // public GameObject Sad;
    // public GameObject Angry;
    // public GameObject Surprised;
    // public Button SadButton;

    // public Button HappyButton;

    // public Button AngryButton;

    // public Button SurprisedButton;

    Dictionary<int, string> emotionDict = new Dictionary<int, string>()
    {
        {0, "Sad"},
        {1, "Happy"},
        {2, "Angry"},
        {3, "Surprised"}
    };

    void Start(){

        DoSomethingLater();
    }

    public void DoSomethingLater()
    {
        Invoke("DoSomething", 2f);
    }

    void DoSomething()
    {
        GameManager.Instance.LoadScene("EmotionExpressionModulePrototype");
        // GameManager.Instance.LoadScene("EmotionMatching");
    }


    // void Start()
    // {
    //     // ImagesArray = [Sad, Happy, Angry, Surprised];
    //     emotionPictures = new GameObject[4];

    //     emotionPictures[0] = Sad;
    //     emotionPictures[1] = Happy;
    //     emotionPictures[2] = Angry;
    //     emotionPictures[3] = Surprised;

    //     emotionButtons[0] = SadButton;
    //     emotionButtons[1] = HappyButton;
    //     emotionButtons[2] = AngryButton;
    //     emotionButtons[3] = SurprisedButton;

    //     // Assign click events to buttons
    //     for (int i = 0; i < 4; i++)
    //     {
    //         int index = i; // Capture the current value of i for the callback
    //         emotionButtons[i].onClick.AddListener(() => OnButtonClick(index));
    //     }

    //     // Shuffle the order of emotion buttons and pictures
    //     // ShuffleArrays(emotionPictures, emotionButtons);

    //     // Update the UI
    //     UpdateUI();
    // }

    // void Update()
    // {
    //     if (gameActive)
    //     {
    //         // Update the timer
    //         timer -= Time.deltaTime;
    //         // timerText.text = $"Time: {Mathf.Round(timer)}";

    //         // Check for game over condition
    //         if (timer <= 0f)
    //         {
    //             gameActive = false;
    //             ShowGameOverScreen();
    //         }
    //     }
    // }

    // void OnButtonClick(int buttonIndex)
    // {
    //     if (gameActive)
    //     {
    //         // Check if the clicked button matches the correct emotion index
    //         if (buttonIndex == GetCorrectEmotionIndex())
    //         {
    //             correctMatches++;

    //             // Check for a win
    //             if (correctMatches == emotionButtons.Length)
    //             {
    //                 gameActive = false;
    //                 ShowYouWonScreen();
    //             }
    //             else
    //             {
    //                 // Update the UI for the next round
    //                 UpdateUI();
    //             }
    //         }
    //     }
    // }

    // void UpdateUI()
    // {
    //     // Update the UI to display the current set of emotion pictures
    //     for (int i = 0; i < 4; i++)
    //     {
    //         emotionPictures[i].SetActive(true);
    //     }
    // }

    // Sprite GetEmotionSprite(int index)
    // {
    //     // Return the Sprite for the emotion picture at the specified index
    //     // This method should be implemented based on your specific setup
    //     // Replace it with your logic for retrieving emotion sprites
    //     // ...

    //     // Placeholder implementation (replace with your actual logic)
    //     return null;
    // }

    // int GetCorrectEmotionIndex()
    // {
    //     // Define the correct order of emotions (change this based on your specific setup)
    //     int[] correctOrder = { 0, 1, 2, 3 };  // Adjust the indices based on your actual order

    //     // Find the index of the correct emotion in the shuffled order
    //     for (int i = 0; i < emotionButtons.Length; i++)
    //     {
    //         if (emotionButtons[i].GetComponentInChildren<Text>().text == emotionDict[correctOrder[i]])
    //         {
    //             return i;
    //         }
    //     }

    //     // Default to the first button (in case of an issue)
    //     return 0;
    // }

    // void ShowGameOverScreen()
    // {
    //     // Display the game over screen
    //     // gameOverScreen.SetActive(true);
    //     Debug.Log("Game Over");

    // }

    // void ShowYouWonScreen()
    // {
    //     // Display the you won screen
    //     // youWonScreen.SetActive(true);
    //     Debug.Log("You Won");

    // }

}
