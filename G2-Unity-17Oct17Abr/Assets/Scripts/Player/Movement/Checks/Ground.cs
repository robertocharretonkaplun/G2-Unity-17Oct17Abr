using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
  public bool onGround;
  private float friction;

  private void OnCollisionEnter2D(Collision2D collision)
  {
    EvaluateCollision(collision);
    RetrieveFriction(collision);
  }

  private void OnCollisionStay2D(Collision2D collision)
  {
    EvaluateCollision(collision);
    RetrieveFriction(collision);
  }

  private void OnCollisionExit2D(Collision2D collision)
  {
    onGround = false;
    friction = 0;
  }

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
    // Obtener una copia local de nuestro material fisico
    PhysicsMaterial2D material = collision.rigidbody.sharedMaterial;

    // Settear la variable de friction a 0
    friction = 0;

    // Asignacion del valor de la friccion del material
    if (material != null)
    {
      friction = material.friction;
    }
  }

  public bool GetOnGround()
  {
    return onGround;
  }

  public float GetFriction()
  {
    return friction;
  }
}
