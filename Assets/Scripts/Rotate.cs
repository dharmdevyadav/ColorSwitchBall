using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
  [SerializeField] private float RotateSpeed=100f;
  private Rigidbody2D rb;

  public void Start()
  {
    rb=GetComponent<Rigidbody2D>();
  }
  void Update()
    {
    transform.Rotate(rb.velocity.x,rb.velocity.y,RotateSpeed * Time.deltaTime);
    }
}
