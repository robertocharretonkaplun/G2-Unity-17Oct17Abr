using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
  public int OrderInLayer = 0;
  // Start is called before the first frame update
  void Start()
  {
    if (IsAreaSpawn == false)
    {
      SpawnTrees();
    }
  }

  public void SpawnTrees()
  {
    if (!IsSpawned)
    {

      foreach (Vector2 TreePos in PropsPositions)
      {
        // Get Random Tree
        int rand = Random.Range(0, Prefabs.Count);
        // Instantiate a new Tree in a specific pos from list
        GameObject TmpTree = Instantiate(Prefabs[rand], TreePos, Quaternion.identity);
        if (hasOrderInLayer)
        {
          int randOrder = Random.Range(2, 6);
          TmpTree.GetComponent<SpriteRenderer>().sortingOrder = randOrder;
        }
        else
        {
          TmpTree.GetComponent<SpriteRenderer>().sortingOrder = OrderInLayer;
        }
        // Add the prop as a child of the propsobj
        TmpTree.transform.parent = PropsObj.transform;
        // Save the Tree in the Gameobjects list
        Props.Add(TmpTree);
      }
      IsSpawned = true;
    }
  }

  private void OnDrawGizmos()
  {
    Gizmos.color = GizmosColor;
    foreach (Vector2 Pos in PropsPositions)
    {
      Gizmos.DrawWireSphere(Pos, 0.5f);
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      SpawnTrees();
    }
  }
}
