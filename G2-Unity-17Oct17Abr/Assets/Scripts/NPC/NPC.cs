using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : InteractObj
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (IsPlayerNearToObject())
    {
      DialogManager.instance.StartDialog();
      if (Input.GetKey(KeyCode.E))
      {
        DialogManager.instance.NextDialog();
      }
    }
    else
    {
      DialogManager.instance.RestartDialogs();
    }
  }
}
