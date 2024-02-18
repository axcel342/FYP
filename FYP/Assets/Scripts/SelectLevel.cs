using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
  public void PlayFirstModule() {
    SceneManager.LoadScene(2);
  }

  public void PlaySecondModule() {
    SceneManager.LoadScene(3);
  }

  public void PlayThirdModule() {
    SceneManager.LoadScene(4);
  }

  public void GoBack() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }

}
