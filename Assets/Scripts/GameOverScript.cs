using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
  public Button NextButton;
  public static bool isOpenStartWindow=false;
  private void Start()
  {
    if (GameManager.isNextLevel == false)
    {
      NextButton.interactable = false;
    }
    else
    {
      NextButton.interactable = true;
    }
  }
  public void NextLoad()
  {
    SceneManager.LoadScene("Level2");
  }
  public void ExitGame()
  {
    Time.timeScale = 1f;
    isOpenStartWindow = true;
    SceneManager.LoadScene("StartMenu");
  }

}
