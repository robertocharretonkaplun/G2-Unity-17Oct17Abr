using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager_Tutorial : MonoBehaviour
{
  public static LevelManager_Tutorial instance;
  public GameObject InteractionScreen;
  public bool IsPlayerInteracting;

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

  }
  
  // Update is called once per frame
  void Update()
  {

    InteractionScreen.SetActive(IsPlayerInteracting);

  }
}
