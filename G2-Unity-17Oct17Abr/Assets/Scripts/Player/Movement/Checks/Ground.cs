using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
  public bool onGround;
  private float friction;

  // Evaluamos si el jugador esta tocando o no el suelo
  private void EvaluateCollision(Collision2D collision)
  {
    for (int i = 0; i < collision.contactCount; i++)
    {
      Vector2 normal = collision.GetContact(i).normal;
      onGround |= normal.y >= 0.9f;
    }


  }

  // Evaluar si existe friccion dentro del entorno
  private void RetrieveFriction(Collision2D collision)
  {

  }
}
