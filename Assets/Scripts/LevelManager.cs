using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
  private int previousLevelIndex;

  void Start()
  {
    // Get the index of the previous level
    previousLevelIndex = SceneManager.GetActiveScene().buildIndex;
  }

  public void LoadGameOverScene()
  {
    // Store the index of the previous level before loading the GameOver scene
    PlayerPrefs.SetInt("PreviousLevelIndex", previousLevelIndex);
    SceneManager.LoadScene("LevelCompleted");
  }

  public void RestartLevel()
  {
    // Get the index of the previous level from PlayerPrefs
    int previousIndex = PlayerPrefs.GetInt("PreviousLevelIndex", -1);

    // Check if the previous index is valid
    if (previousIndex >= 0)
    {
      SceneManager.LoadScene(previousIndex);
    }
    else
    {
      Debug.LogWarning("No previous level found.");
    }
  }
}
