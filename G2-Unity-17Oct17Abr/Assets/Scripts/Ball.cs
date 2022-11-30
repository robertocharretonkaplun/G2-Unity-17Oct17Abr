using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Estructura de una variable -> tipo + nombre + asgnacion (=) + valor asignado + ;


public class Ball : MonoBehaviour
{
  private Rigidbody2D RB;
  private float initVelocity = 4f;
  public float MultiplyVelocity = 1.1f;
  // Start is called before the first frame update
  void Start()
  {
    RB = GetComponent<Rigidbody2D>();
    Launch(); // -> Llamada de funcion
  }

  // Update is called once per frame
  void Update()
  {
  }

  void Launch()
  {
    float x = Random.Range(0, 2) == 0 ? -1 : 1; // 0 = -1, 1 o 2 = 1;
    float y = Random.Range(0, 2) == 0 ? -1 : 1; // 0 = -1, 1 o 2 = 1;
    RB.velocity = new Vector2(x, y) * initVelocity;
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("LeftKillWall") || collision.CompareTag("RightKillWall"))
    {
      if (collision.CompareTag("LeftKillWall"))
      {
        LevelManager.instance.P2Score += 1;
      }
      if (collision.CompareTag("RightKillWall"))
      {
        LevelManager.instance.P1Score += 1;
      }

      LevelManager.instance.UpdateScore();
      RB.velocity = new Vector2(0, 0); // Reset Velocity to 0
      transform.position = new Vector3(0, 0, 0); // Align ball in the middle of the screen
      Launch();
    }
  }

}
