using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public void Pass()
  {
    int currentLevel = SceneManager.GetActiveScene().buildIndex;
    if (currentLevel >= PlayerPrefs.GetInt("LevelUnlocked"))
    {
      PlayerPrefs.SetInt("LevelUnlocked", currentLevel +1);
    }
  }
}
