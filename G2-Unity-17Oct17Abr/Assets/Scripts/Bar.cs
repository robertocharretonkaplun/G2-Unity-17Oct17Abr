using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
  public bool IsBar1 = false;
  private float speed = 7f;
  public float YLimit = 3.4f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    Movement();
  }

  public void Movement()
  {
    float move = 0;

    // Asignacion de la barra para Izquierda o Derecha
    if (IsBar1 == true)
    {
      move = Input.GetAxisRaw("Vertical2");
      Debug.Log("Input de bar 1:" + move.ToString());
    }
    else
    {
      move = Input.GetAxisRaw("Vertical");
    }
    // Movimiento Barra
    Vector2 BarPos = transform.position;
    BarPos.y = Mathf.Clamp(BarPos.y + move * speed * Time.deltaTime, -YLimit, YLimit);
    transform.position = BarPos;

  }
}
