using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
  GameOverScript gameOver;

  private void Start()
  {
    gameOver = FindObjectOfType<GameOverScript>();
  }
  public void StartMenuScene()
  {
    gameOver.ExitGame();
  }
  
}
