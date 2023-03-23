using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
  public int health = 50;
  public int Esmeraldas = 100;
  public List<string> Inventory;
  public ProgressBar HealthBar;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    HealthBar.current = health;
  }
}
