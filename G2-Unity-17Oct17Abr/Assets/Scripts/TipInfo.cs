using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TipInfo : MonoBehaviour
{
  public string TextInScreen;
  private TMP_Text TextUI;
  // Start is called before the first frame update
  void Start()
  {
    // Este es el ejemplo de sobre escritura de un archivo
    TextUI = GetComponent<TMP_Text>();
    TextUI.alignment = TextAlignmentOptions.Center;
    TextUI.alignment = TextAlignmentOptions.Baseline;

    TextUI.text = TextInScreen;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
