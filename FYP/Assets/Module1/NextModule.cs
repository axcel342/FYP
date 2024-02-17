using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextModule : MonoBehaviour
{
 
public void Start()
{
    // Hide the LevelComplete GameObject
    // LevelComplete.SetActive(false);
}

public void Update()
{

}
 
public GameObject LevelComplete; 

public void onClick(){
    LevelComplete.SetActive(true);
}
public void HandleNextModuleButton()
{
    // Access Game Manager instance
    GameManager.Instance.LoadScene("EmotionMatchingModulePrototype");

    // Optional visual feedback
    // GetComponent<Image>().color = Color.red; // Change button color
    // PlaySound("ButtonPress"); // Play sound effect
}
}
