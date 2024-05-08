using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
  public int score;
  public TextMeshProUGUI scoreText;
  public GameObject PointText;
  public GameObject PointText2;
  public GameObject PointText3;
  public GameObject PointText4;
  public GameObject PointText5;
  public GameObject FinishPanel;
  public GameObject Homebutton;
  public GameObject NextButton;
  public GameObject BackPanel;
  public string PreviousScene;
  public static bool isNextLevel=true;
  public void Start()
  {
    FinishPanel.SetActive(false);
    PointText.SetActive(false);
    PointText2.SetActive(false);
    PointText3.SetActive(false);
    PointText4.SetActive(false);
    PointText5.SetActive(false);
    scoreText = FindObjectOfType<TextMeshProUGUI>();
  }
 
  public void StartGame()
  {
    PreviousScene = "Level1";
    SceneManager.LoadScene(PreviousScene);
  }
  
  public void OpenBackPanel()
  {
    Time.timeScale = 0f;
    BackPanel.SetActive(true);
  }
  public void Resume()
  {
    BackPanel.SetActive(false);
    Time.timeScale = 1f;
  }
  public void RestartGame()
  {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
  public void QuitGame()
  {
    Application.Quit();
  }

}
