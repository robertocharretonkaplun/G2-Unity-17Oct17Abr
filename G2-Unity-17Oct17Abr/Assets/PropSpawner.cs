using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct POINT
{
  [Tooltip("This variable sets the int minInclusive of the range")]
  public int Range1;
  [Tooltip("This variable sets the int maxInclusive of the range")]
  public int Range2;
}


public class PropSpawner : MonoBehaviour
{
  [Header("SPAW CONFIGURATION")]
  public bool IsAreaSpawn = false;
  public bool IsSpawned = false;
  public Color GizmosColor;
  public List<GameObject> Prefabs;
  public List<Vector2> PropsPositions;
  [Header("PROPS CONFIGURATION")]
  public GameObject PropsObj;
  public List<GameObject> Props;
  [Header("ORDER IN LAYER")]
  public bool hasOrderInLayer = true;
  public Vector2Int LayerIndex;
  public int OrderInLayer = 0;

  // Start is called before the first frame update
  void Start()
  {
    if (IsAreaSpawn == false)
    {
      Spawn();
    }
  }

  public void 
  Spawn() {
    if (!IsSpawned) {
      foreach (Vector2 TreePos in PropsPositions) {
        // Get Random Tree
        int rand = Random.Range(0, Prefabs.Count);
        // Instantiate a new Tree in a specific pos from list
        GameObject TmpProp = Instantiate(Prefabs[rand], 
                                         TreePos, 
                                         Quaternion.identity);
        // Se the order in layer of prop
        SetOrderInLayer(TmpProp);
        // Add the prop as a child of the propsobj
        SetParent(TmpProp);
        // Save the TmpProp in the Gameobjects list
        Props.Add(TmpProp);
      }
      IsSpawned = true;
    }
  }

  public void 
  SetParent(GameObject obj) {
    obj.transform.parent = PropsObj.transform;
  }

  public void 
  SetOrderInLayer(GameObject obj) {
    if (hasOrderInLayer) {
      int randOrder = Random.Range(LayerIndex.x, LayerIndex.y);
      if (obj.GetComponent<SpriteRenderer>() != null) {
        obj.GetComponent<SpriteRenderer>().sortingOrder = randOrder;
      }
    }
    else {
      if (obj.GetComponent<SpriteRenderer>() != null) {
        obj.GetComponent<SpriteRenderer>().sortingOrder = OrderInLayer;
      }
    }
  }

  private void 
  OnDrawGizmos() {
    Gizmos.color = GizmosColor;
    foreach (Vector2 Pos in PropsPositions) {
      Gizmos.DrawWireSphere(Pos, 0.5f);
    }
  }

  private void 
  OnTriggerEnter2D(Collider2D collision) {
    if (collision.gameObject.CompareTag("Player")) {
      Spawn();
    }
  }
}
