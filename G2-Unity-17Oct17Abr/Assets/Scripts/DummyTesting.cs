using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase esta encargada de poder comunicar y encapsular la informacion de un script
public class DummyTesting : MonoBehaviour
{
  // ESTRUCTURA DE UNA VARIABLE: PUBLIC/PRIVATE + TIPO DE DATO + NOMBRE DE LA VARIABLE + DATO ASIGNADO

  // VARIABLES NATIVAS DEL C#
  public int Edad = 23;
  public float Estatura = 1.83f;
  public bool RecibiDano = false;
  public char letras = 'a';
  public double Contraseña = 123456789;
  public string nombre = "Roberto";

  public bool IsInUpdate = true;
  public bool IsInFixedUpdate = true;
  public bool IsInLateUpdate = true;
  // VARIABLES NATIVAS DE UNITY
  public Vector3 Posicion;

  

  private void OnCollisionEnter2D(Collision2D collision)
  {
    Debug.Log(name +  " collide with: " + collision.gameObject.name);
  }
}
