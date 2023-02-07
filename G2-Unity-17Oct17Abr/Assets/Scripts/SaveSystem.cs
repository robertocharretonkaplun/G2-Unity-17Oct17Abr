using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SaveSystem : MonoBehaviour
{
  public int puntos = 0;
  public TMP_Text puntosTxt;

  private void Update()
  {
    puntosTxt.text = "Points: " + puntos.ToString();
  }

  public void IncrementarPuntos()
  {
    puntos++;
  }

  public void DecrementarPuntos()
  {
    puntos--;
  }

}
