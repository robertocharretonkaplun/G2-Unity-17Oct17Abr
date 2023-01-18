using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Store : MonoBehaviour
{
  public GameObject ObjectText;

  public bool IsPlayerNear = false;
  // Start is called before the first frame update
  void Start()
  {
    ObjectText.GetComponent<TMP_Text>().text = "Store (Press 'E' to interact)";
  }

  // Update is called once per frame
  void Update()
  {

    ObjectText.SetActive(IsPlayerNear);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    // Detectectamos si el jugador esta cerca de nosotros
    if (collision.gameObject.CompareTag("Player"))
    {
      // Si el jugador esta cerca de nosotros activaremos nuesta ventana
      IsPlayerNear = true;
      var StoreAmount = LevelManager_Tutorial.instance.StoreAmount - 1;
      Debug.Log("Puedes consultar en las otras " + StoreAmount.ToString() + " tiendas");
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    // Detectectamos si el jugador esta saliendo de la zona de deteccion de nosotros
    if (collision.gameObject.CompareTag("Player"))
    {
      // Si el jugador esta lejos de nosotros desactivaremos nuesta ventana
      IsPlayerNear = false;
      LevelManager_Tutorial.instance.IsPlayerInteracting = false;
    }
  }
}
