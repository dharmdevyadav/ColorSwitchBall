using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
  public int score;
  public TextMeshProUGUI scoreText;
  public void Start()
  {
    scoreText=FindObjectOfType<TextMeshProUGUI>();
    
  }
}
