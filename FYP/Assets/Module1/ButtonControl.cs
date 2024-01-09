using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ButtonControl : MonoBehaviour
{
    public GameObject LevelComplete;
    public GameObject Happy;
    public GameObject Sad;
    public GameObject Angry;
    public GameObject Surprised;
    public GameObject Scared;

    public GameObject Happy1;
    public GameObject Sad1;
    public GameObject Angry1;
    public GameObject Surprised1;
    public GameObject Scared1;
    public Button SadButton;

    public Button HappyButton;

    public Button AngryButton;

    public Button SurprisedButton;

    public Button ScaredButton;
    // private Button btn;
    public TMP_Text scoreText;

    public TMP_Text incorrectText;

    public float incorrectMessageDuration = 1f;
    public float imageDisplayTime = 1f; // Time each image is displayed
    // private int currentIndex = 0; // Index of the current image
    private int score = 0; // Player's score

    private GameObject CurrentImage;
    private GameObject PreviousImage;

    private GameObject[] ImagesArray;

    private int imageIndex;
    void Start()
    {
        // ImagesArray = [Sad, Happy, Angry, Surprised];
        ImagesArray = new GameObject[10];
        imageIndex = 0;

        ImagesArray[0] = Sad;
        ImagesArray[1] = Happy;
        ImagesArray[2] = Angry;
        ImagesArray[3] = Surprised;
        ImagesArray[4] = Scared;
        ImagesArray[5] = Sad1;
        ImagesArray[6] = Happy1;
        ImagesArray[7] = Angry1;
        ImagesArray[8] = Surprised1;
        ImagesArray[9] = Scared1;

        PreviousImage = Sad;
        CurrentImage = Sad;
        // Set the initial image
        SetNextImage();

        // Add a listener to the button to handle button click
        // btn = this.GetComponent<Button>(identifyButton);
		SadButton.onClick.AddListener(() => {IdentifyButtonClick(SadButton);});
        HappyButton.onClick.AddListener(() => {IdentifyButtonClick(HappyButton);});
        AngryButton.onClick.AddListener(() => {IdentifyButtonClick(AngryButton);});
        SurprisedButton.onClick.AddListener(() => {IdentifyButtonClick(SurprisedButton);});
        ScaredButton.onClick.AddListener(() => {IdentifyButtonClick(ScaredButton);});
        // identifyButton.onClick.AddListener(IdentifyButtonClick);

        // Start the coroutine to cycle through images
        StartCoroutine(DisplayImages());
    }

    void Update(){
        // btn = this.GetComponent<Button>();
		// SadButton.onClick.AddListener(() => {IdentifyButtonClick(SadButton);});
        // HappyButton.onClick.AddListener(() => {IdentifyButtonClick(HappyButton);});
        // AngryButton.onClick.AddListener(() => {IdentifyButtonClick(AngryButton);});
        // SurprisedButton.onClick.AddListener(() => {IdentifyButtonClick(SurprisedButton);});
        scoreText.SetText("Score: " + score);
    }

    void SetNextImage()
    {
        // Set the image for the Image component based on the current index
        // GetComponent<Image>().sprite = images[currentIndex];
        PreviousImage.SetActive(false);

        CurrentImage.SetActive(true);

        Debug.Log(PreviousImage.tag);

        Debug.Log(score);

    }

    IEnumerator DisplayImages()
    {
        while (true)
        {
            // Wait for the specified time before moving to the next image
            yield return new WaitForSeconds(imageDisplayTime);

            // Move to the next image in the array
            // currentIndex = (currentIndex + 1) % images.Length;
            // imageIndex++;
            SetNextImage();
        }
    }

    void IdentifyButtonClick(Button btn)
    {
        imageIndex++;

        if (imageIndex == 10){
            imageIndex = 0;
            scoreText.enabled = false;
            LevelComplete.SetActive(true);

        }

        // Check if the current image is correctly identified
        if (btn.GetComponentInChildren<TMP_Text>().text == "Sad" && CurrentImage.CompareTag("Sad"))
        {
            // Increment the score by 10 for each correct identification
            score += 10;
            // Update the score text
            // scoreText.text = "Score: " + score;

            // Move to the next image
            // currentIndex = (currentIndex + 1) % images.Length;

            PreviousImage = CurrentImage;
            CurrentImage = ImagesArray[imageIndex];
            SetNextImage();
        }

        else if (btn.GetComponentInChildren<TMP_Text>().text == "Happy" && CurrentImage.CompareTag("Happy"))
        {
            // Increment the score by 10 for each correct identification
            score += 10;
            // Update the score text
            // scoreText.text = "Score: " + score;

            // Move to the next image
            // currentIndex = (currentIndex + 1) % images.Length;

            PreviousImage = CurrentImage;
            CurrentImage = ImagesArray[imageIndex];
            SetNextImage();
        }

        else if (btn.GetComponentInChildren<TMP_Text>().text == "Angry" && CurrentImage.CompareTag("Angry"))
        {
            // Increment the score by 10 for each correct identification
            score += 10;
            // Update the score text
            // scoreText.text = "Score: " + score;

            // Move to the next image
            // currentIndex = (currentIndex + 1) % images.Length;

            PreviousImage = CurrentImage;
            CurrentImage = ImagesArray[imageIndex];
            SetNextImage();
        }

        else if (btn.GetComponentInChildren<TMP_Text>().text == "Surprised" && CurrentImage.CompareTag("Surprised"))
        {
            // Increment the score by 10 for each correct identification
            score += 10;
            // Update the score text
            // scoreText.text = "Score: " + score;

            // Move to the next image
            // currentIndex = (currentIndex + 1) % images.Length;

            PreviousImage = CurrentImage;
            CurrentImage = ImagesArray[imageIndex];
            SetNextImage();
        }

        else if (btn.GetComponentInChildren<TMP_Text>().text == "Scared" && CurrentImage.CompareTag("Scared"))
        {
            // Increment the score by 10 for each correct identification
            score += 10;
            // Update the score text
            // scoreText.text = "Score: " + score;

            // Move to the next image
            // currentIndex = (currentIndex + 1) % images.Length;

            PreviousImage = CurrentImage;
            CurrentImage = ImagesArray[imageIndex];
            SetNextImage();
        }        

        else
        {
            // Incorrect identification logic (if needed)
            ShowIncorrectMessage();
            Debug.Log("Incorrect identification!");
            PreviousImage = CurrentImage;
            CurrentImage = ImagesArray[imageIndex];
            SetNextImage();
        }
    }

    void ShowIncorrectMessage()
    {
        // Display the incorrect message for a specific duration
        StartCoroutine(FlashIncorrectMessage());
    }

    IEnumerator FlashIncorrectMessage()
    {
        // Show the incorrect message
        incorrectText.gameObject.SetActive(true);
        Debug.Log("Called");

        // Wait for the specified duration
        yield return new WaitForSeconds(incorrectMessageDuration);

        // Hide the incorrect message
        incorrectText.gameObject.SetActive(false);
    }

}
