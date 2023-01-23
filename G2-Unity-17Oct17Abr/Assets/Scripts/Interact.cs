using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
  public bool IsInteracting = false;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Llamada de la funcion Input para pode interactuar con objetos en el mundo.
    Inputs();
  }

  /// <summary>
  /// Esta funcion esta encargada de almacenar los inputs ingresados por el usuario.
  /// </summary>
  public void Inputs()
  {
    // Esta condicion evalua si se esta tocando una tecla, en esta la tecla 'e'
    if (Input.GetKey(KeyCode.E))
    {
      // Mandamos a llamar la variable IsPlayerInteracting para mostrar la ventana de interaccion.
      LevelManager_Tutorial.instance.IsPlayerInteracting = true;
      IsInteracting = false;
    }

  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Intraction"))
    {
      IsInteracting = true;
      Debug.Log("Existe un objeto de interaccion llamado:" + collision.gameObject.name);
    }
  }
}
