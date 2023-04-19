
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager_Tutorial : MonoBehaviour
{
  public static LevelManager_Tutorial instance;

  public GameObject Player; // Prefab
  public Transform PlayerSpawnPos;
  public GameObject PlayerRef;
  /// <summary>
  /// Este objeto es la ventana de interaccion.
  /// </summary>
  public GameObject InteractionScreen;


  public int StoreAmount = 5;
  /// <summary>
  /// Esta variable esta encargada de activar o desactivar la ventana de interaccion.
  /// </summary>
  public bool IsPlayerInteracting;

  public bool LoadNextZone = false;

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
    // Spawn a player in the world
    //PlayerRef = Instantiate(Player, PlayerSpawnPos.position, Quaternion.identity);
    //PlayerRef.name = "Dani";
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

  public void LooseCondition()
  {
    if (PlayerRef.GetComponent<PlayerController>().Health <= 0)
    {
      // Mostrar que el jugador murio
    }
  }
}
