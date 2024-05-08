using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  [SerializeField] private Transform Player;
    void Update()
    {
    if(Player.position.y>transform.position.y)
    {
      transform.position =new Vector3(Player.position.x,Player.position.y,Player.position.z-10);
    }
        
    }
}
