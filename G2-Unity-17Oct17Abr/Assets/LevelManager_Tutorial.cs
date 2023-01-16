using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager_Tutorial : MonoBehaviour
{
  public static LevelManager_Tutorial instance;

  /// <summary>
  /// Este objeto es la ventana de interaccion.
  /// </summary>
  public GameObject InteractionScreen;

  /// <summary>
  /// Esta variable esta encargada de activar o desactivar la ventana de interaccion.
  /// </summary>
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

  public void CloseInteractingWindow()
  {
    IsPlayerInteracting = false;
  }
}
