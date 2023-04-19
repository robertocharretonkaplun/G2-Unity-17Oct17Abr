using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : InteractObj
{
  public GameObject DropItem;
  public bool canDropItem = false;
  public int maxDrops = 1;
  private int currentDrops = 0;
  // Start is called before the first frame update
  void Start()
  {

  }

  IEnumerator DropItemToPlayer()
  {
    // Spawn Object
    //canDropItem = true;
    yield return new WaitForSeconds(.1f);
    // Spawn Object
    if (canDropItem == true && currentDrops < maxDrops)
    {
      Instantiate(DropItem, transform.position - new Vector3(1, 0, 0), Quaternion.identity);
      currentDrops++;
      canDropItem = false;
    }
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

    // Check if dialogs end
    if (DialogManager.instance.currentLineIndex == DialogManager.instance.Dialogs.Count - 1)
    {
      canDropItem = true;
    }
    // Drop Item
    StartCoroutine(DropItemToPlayer());
  }
}
