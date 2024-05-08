using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPage : MonoBehaviour
{
  public GameObject QuitButton;
  private void Start()
  {
    if (GameOverScript.isOpenStartWindow == true)
    {
      QuitButton.SetActive(true);
    }
  }

}
