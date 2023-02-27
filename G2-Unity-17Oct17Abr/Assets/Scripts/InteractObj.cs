using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InteractObj : MonoBehaviour
{
  public GameObject ObjectText;
  public string TextInput;
  public bool IsPlayerNear = false;
  public bool IsInteracting = false;

  // Start is called before the first frame update
  void Start()
  {
    //ObjectText.GetComponent<TMP_Text>().text = "Store (Press 'E' to interact)";
    //ObjectText.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = TextInput;
  }

  // Update is called once per frame
  void Update()
  {
    ObjectText.SetActive(IsPlayerNear);

    // Check if the player is interacting with the object
    if (IsPlayerNear == true)
    {
      if (Input.GetKey(KeyCode.E))
      {
        IsInteracting = true;
      }
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    // Detectectamos si el jugador esta cerca de nosotros
    if (collision.gameObject.CompareTag("Player"))
    {
      // Si el jugador esta cerca de nosotros activaremos nuesta ventana
      IsPlayerNear = true;
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    // Detectectamos si el jugador esta saliendo de la zona de deteccion de nosotros
    if (collision.gameObject.CompareTag("Player"))
    {
      // Si el jugador esta lejos de nosotros desactivaremos nuesta ventana
      IsPlayerNear = false;
    }
  }
}
