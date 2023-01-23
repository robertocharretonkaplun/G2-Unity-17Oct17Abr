using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
  public GameObject Tree1;
  public List<GameObject> Prefabs;
  public List<Transform> TreeSpawnPos;
  public List<GameObject> Trees;
  // Start is called before the first frame update
  void Start()
  {
    // Revisamos si el gameobjet tiene hijos 
    for (int i = 0; i < transform.childCount; i++)
    {
      // Guardamos en la lista de posiciones a todas las posiciones de los hijos existentes.
      TreeSpawnPos.Add(transform.GetChild(i).transform);
    }

    // Spawn trees
    //for (int i = 0; i < TreeSpawnPos.Count; i++)
    //{
    //  GameObject TmpTree = Instantiate(Tree1, TreeSpawnPos[i].position, Quaternion.identity);
    //  Trees.Add(TmpTree);
    //}

    foreach (Transform TreePos in TreeSpawnPos)
    {
      // Get Random Tree
      int rand = Random.Range(0, Prefabs.Count);
      // Instantiate a new Tree in a specific pos from list
      GameObject TmpTree = Instantiate(Prefabs[rand], TreePos.position, Quaternion.identity);
      // Save the Tree in the Gameobjects list
      Trees.Add(TmpTree);
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
