using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
  public int health = 50;
  public int Esmeraldas = 100;
  public int Elixir = 100;
  public List<GameObject> Inventory;
  public ProgressBar HealthBar;
  public ProgressBar ElixirBar;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (HealthBar != null)
    {

      HealthBar.current = health;
      ElixirBar.current = Elixir;
    }
  }
}
