using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Image image;
    public Button identifyButton;
    public GameObject sadPanel;

    void Start()
    {
        identifyButton.onClick.AddListener(IdentifyButtonClick);
        Debug.Log(identifyButton);
    }
    void IdentifyButtonClick()
    {
        // Check if the button text is "Sad"
        if (identifyButton.GetComponentInChildren<TextMeshPro>().text == "Sad")
        {
            // Display the sad panel
            sadPanel.SetActive(true);
        }
        else
        {
            // Add your logic here for identifying the image (if needed)
            Debug.Log("Image identified!");
        }
    }
}
