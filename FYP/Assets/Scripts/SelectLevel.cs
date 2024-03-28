using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
  public void PlayFirstModule() {
    SceneManager.LoadScene(3);
  }

  public void PlaySecondModule() {
    SceneManager.LoadScene(4);
  }

  public void PlayThirdModule() {
    SceneManager.LoadScene(5);
  }

  public void GoBack() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }

}
