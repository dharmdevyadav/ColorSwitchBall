using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisable : MonoBehaviour
{
  [SerializeField] GameObject Player;
    public void DisablePlayer()
  {
    Player.SetActive(false);
  }
}
