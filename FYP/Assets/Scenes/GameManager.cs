using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Static instance to access this manager from anywhere
    public static GameManager Instance;

    // Define scene names or indices here
    public string MainMenuScene;
    public string GameplayScene;
    public string GameOverScene;

    private void Awake()
    {
        // Make this object persistent across scenes
        // DontDestroyOnLoad(gameObject);

        // Set static instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Load Scene by name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Load Scene by index (optional)
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Example methods for triggering scene loads based on game events
    public void StartGame()
    {
        LoadScene(GameplayScene);
    }

    public void GoToMainMenu()
    {
        LoadScene(MainMenuScene);
    }

    public void GameOver()
    {
        LoadScene(GameOverScene);
    }
}
