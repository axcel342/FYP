using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
// Array to store image references for each tile
  [SerializeField] public Sprite[] imageChoices;
  
  [SerializeField] public GameObject[] newTile;
  // Array to track revealed tiles
  private bool[] revealedTiles;
  
  // Current score
  private int score;
  
  // Reference to the score text object
  [SerializeField] private Text scoreText;
  
  // Reference to the game grid (parent of all tile images)
  [SerializeField] private Transform tileGrid;
  
  // Reference to the image prefab used for tiles
  [SerializeField] private GameObject tilePrefab;
  
  // Previously clicked tile image (for comparison)
  private Image previousClickedImage;

  void Start()
  {
    // Initialize variables
    revealedTiles = new bool[imageChoices.Length];
    score = 0;
    scoreText.text = "Score: " + score;
    
    // Generate a random order for image choices
    ShuffleArray(imageChoices);
    
    // Create tiles and assign random images
    // for (int i = 0; i < imageChoices.Length; i++)
    // {
    //   // GameObject newTile = Instantiate(tilePrefab, tileGrid);
    //   // newTile[i].GetComponent<sprite>().sprite = null;
    // //   newTile.GetComponent<Image>().sprite = null; // Hide image initially
    //   // newTile.GetComponent<Button>().onClick.AddListener(() => OnTileClick(newTile.GetComponent<Image>()));
    // }

    foreach (GameObject tile in newTile)
    {
      tile.GetComponent<SpriteRenderer>().sprite = null; // Hide image initially
      // tile.GetComponent<Button>().onClick.AddListener(() => OnTileClick(tile.GetComponent<Image>()));

    }
  }

  void OnTileClick(Image clickedImage)
  {
    // Get the index of the clicked tile
    int tileIndex = GetTileIndex(clickedImage.transform);

    // Check if tile is already revealed
    if (!revealedTiles[tileIndex])
    {
      revealedTiles[tileIndex] = true;
      clickedImage.sprite = imageChoices[tileIndex]; // Reveal image

      // Check for a match if there's a previous clicked tile
      if (previousClickedImage != null && 
          previousClickedImage.sprite == clickedImage.sprite)
      {
        score++;
        scoreText.text = "Score: " + score;
        previousClickedImage = null; // Reset comparison

        // Check if all tiles are matched
        if (IsAllMatched())
        {
          LoadNewImages(); // Load new set of images
        }
      }
      else
      {
        previousClickedImage = clickedImage; // Store for comparison
      }
    }
  }

  int GetTileIndex(Transform tileTransform)
  {
    // Find the index of the child tile within the grid
    return tileTransform.GetSiblingIndex();
  }

  bool IsAllMatched()
  {
    for (int i = 0; i < revealedTiles.Length; i++)
    {
      if (!revealedTiles[i])
      {
        return false;
      }
    }
    return true;
  }

  void LoadNewImages()
  {
    // Reset revealed tiles and score
    revealedTiles = new bool[imageChoices.Length];
    score = 0;
    scoreText.text = "Score: " + score;
    previousClickedImage = null;

    // Shuffle image choices again for a new round
    ShuffleArray(imageChoices);

    // Update tile images with new choices (can be implemented here or elsewhere)
    for (int i = 0; i < imageChoices.Length; i++)
    {
      tileGrid.GetChild(i).GetComponent<Image>().sprite = null; // Hide image
    }
  }

  // Function to shuffle an array (Fisher-Yates shuffle)
  void ShuffleArray<T>(T[] array)
  {
    System.Random random = new System.Random();
    for (int i = array.Length - 1; i > 0; i--)
    {
      int j = random.Next(i + 1);
      T temp = array[i];
      array[i] = array[j];
      array[j] = temp;
    }
  }
}
