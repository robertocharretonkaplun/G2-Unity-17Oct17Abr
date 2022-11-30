using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelManager : MonoBehaviour
{
  public static LevelManager instance;

  public int P1Score = 0;
  public int P2Score = 0;
  public TMP_Text P1ScoreTxt;
  public TMP_Text P2ScoreTxt;
  public GameObject Ball;
  public GameObject Canvas;


  private void Awake()
  {
    if (instance != null)
    {
      return;
    }
    else
    {
      instance = this;
    }
  }

  // Start is called before the first frame update
  void Start()
  {
    UpdateScore();

    // Instance the ball
    GameObject obj = Instantiate(Ball, new Vector3(0, 0, 0), Quaternion.identity);
    
  }

  // Update is called once per frame
  void Update()
  {
    UpdateScore();
  }

  public void UpdateScore()
  {
    //P1ScoreTxt.text = "P1: " + P1Score.ToString();
    //P2ScoreTxt.text = "P2: " + P2Score.ToString();

    Canvas.transform.GetChild(0).GetComponent<TMP_Text>().text = "P1: " + P1Score.ToString(); 
    Canvas.transform.GetChild(1).GetComponent<TMP_Text>().text = "P2: " + P2Score.ToString(); 
  }


  public void RestartLevel()
  {
    int ResetScore = 0;
    P1Score = ResetScore;
    P2Score = ResetScore;


  }
}
