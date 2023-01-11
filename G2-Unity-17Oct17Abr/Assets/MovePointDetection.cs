using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointDetection : MonoBehaviour
{
  public bool IsObjectNear = false;

  private void Update()
  {
    //var triggerOffset = GetComponent<BoxCollider2D>();
    //triggerOffset.offset = transform.position + new Vector3(1,1,0);

  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Intraction"))
    {
      Debug.Log("Hay un objeto enfrente");
      IsObjectNear = true;
    }
  }
}
