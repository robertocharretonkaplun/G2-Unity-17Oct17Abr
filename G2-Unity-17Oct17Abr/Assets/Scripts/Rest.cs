using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : InteractObj
{
  [Header("Attributes")]
  public GameObject FadeIn;
  public GameObject FadeOut;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (IsInteracting) 
    {
      FadeOut.SetActive(false);
      FadeIn.SetActive(true);
    }
  }
}
