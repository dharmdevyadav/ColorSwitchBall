using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
  [SerializeField] private float JumpSpeed =5.28f;//470
  SpriteRenderer spriteRen;
  GameManager GameScript;
  LevelManager levelManage;
  LevelController LevelControl;
  AudioManager audioManager;
  private Rigidbody2D rb;
  private int Index;
  private string currentColor;
  private bool isClicked;

  private void Start()
  {
    rb=GetComponent<Rigidbody2D>();
    spriteRen=GetComponent<SpriteRenderer>();
    audioManager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    GameScript = FindObjectOfType<GameManager>();
    levelManage = FindObjectOfType<LevelManager>();
    LevelControl=FindObjectOfType<LevelController>();
    Index = Random.Range(0, 4);
    setRandomColor();
  }
 
  private void FixedUpdate()
  {
    if (/*Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)*/isClicked)
    {
      rb.velocity = Vector2.up * JumpSpeed;
      isClicked = false;
    }

   
  }

  public void OnClick()
  {
    isClicked = true;
  }
  public void setRandomColor()
  {
    
    switch (Index)
    {
      case 0:
        currentColor = "Pink";
        spriteRen.color = new Color(1, 0, 0.4f, 1);
        Index = Random.Range(1, 4);
        break;
      case 1:
        currentColor = "Yellow";
        spriteRen.color = new Color(1, 0.91f, 0.12f, 1);
        Index = Random.Range(2, 4);
        break;
      case 2:
        currentColor = "Magenta";
        spriteRen.color = new Color(0.55f, 0.07f, 0.98f, 1);
        Index = Random.Range(0, 1);
        break;
      case 3:
        currentColor = "Cyan";
        spriteRen.color = new Color(0.21f, 0.9f, 0.95f, 1);
        Index = Random.Range(1, 3);
        break;

    }
  }
  public void OnTriggerEnter2D(Collider2D col)
  {
    if (col.tag == "ColorChange")
    {
      setRandomColor();
      Destroy(col.gameObject);
    }
    if (col.tag != currentColor&&col.tag!= "ColorChange"&&col.tag!="Points"&&col.tag!="Extra5"&&col.tag!="Finish"&& col.tag != "FinalLine")
    {
      audioManager.PlayErrorEffect();
      Invoke("LoadCurrentScene", 0.15f);
    }
    if (col.tag == "Points")
    {
      audioManager.PlaycoinCollect();
      GameScript.PointText.SetActive(true);
      GameScript.score+=2;
      GameScript.scoreText.text = "Score:" +GameScript.score.ToString();
      if (GameScript.score > 3&&GameScript.score<5)
      {
        GameScript.PointText2.SetActive(true);
      }
      if (GameScript.score > 5 && GameScript.score <7)
      {
        GameScript.PointText3.SetActive(true);
      }
      if (GameScript.score > 7 && GameScript.score < 9)
      {
        GameScript.PointText4.SetActive(true);
      }
      
      Destroy(col.gameObject);
      
    }
    if (col.tag == "Extra5")
    {
      audioManager.PlaycoinCollect();
      GameScript.score+=5;
      GameScript.scoreText.text ="Score:"+GameScript.score.ToString();
      if (GameScript.score > 9 && GameScript.score < 17)
      {
        GameScript.PointText5.SetActive(true);
      }
      Destroy(col.gameObject);
    }
    if (col.tag == "Finish")
    {
      audioManager.PlayFinishEffect();
      GameScript.FinishPanel.SetActive(true);
      Invoke("LoadNext", 5f);
    }
    if (col.tag == "FinalLine")
    {
      audioManager.PlayFinishEffect();
      GameManager.isNextLevel = false;
      GameScript.FinishPanel.SetActive(true);
      Invoke("LoadNext", 5f);
    }
  } 
  private void LoadNext()
  {
    levelManage.LoadGameOverScene();
  }

  public void LoadCurrentScene()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

}
