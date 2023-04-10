using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : InteractObj
{
  public GameObject DropItem;
  // Start is called before the first frame update
  void Start()
  {

  }

  IEnumerator DropItemToPlayer()
  {
    // Spawn Object
    Instantiate(DropItem, transform.position - new Vector3(1, 0, 0), Quaternion.identity);
    yield return new WaitForSeconds(.5f);
    // Spawn Object
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

    if (DialogManager.instance.currentLineIndex == DialogManager.instance.Dialogs.Count - 1)
    {
      StartCoroutine(DropItemToPlayer());
      //Instantiate(DropItem, transform.position - new Vector3(1, 0, 0), Quaternion.identity);
    }
  }
}
