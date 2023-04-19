using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextZoneGen : MonoBehaviour
{
  public TreeSpawner TreeSpawn;
  public bool LoadNextZone = false;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (LoadNextZone)
    {
      // Spawn Chunk
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      // Unlock Next Zone
      LevelManager_Tutorial.instance.LoadNextZone = true;

      // Initilize Data for Chunk

    }
  }

  public void SpawnChunk()
  {

  }
}
