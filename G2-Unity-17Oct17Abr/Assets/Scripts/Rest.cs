using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : InteractObj
{
  [Header("Attributes")]
  public GameObject FadeIn;
  public GameObject FadeOut;
  public float RestingTime = 1.5f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (IsInteracting)
    {
      StartCoroutine(Resting());
    }
  }

  public IEnumerator Resting()
  {
    // Turn Black the screen
    FadeOut.SetActive(false);
    FadeIn.SetActive(true);
    // Restore Health
    RestorePlayerAttributes();
    
    yield return new WaitForSeconds(RestingTime);
    // Turn normal the screen
    FadeIn.SetActive(false);
    FadeOut.SetActive(true);
    IsInteracting = false;
  }

  public void RestorePlayerAttributes()
  {
    if (PlayerRef.GetComponent<PlayerAttributes>().health < 100)
    {
      PlayerRef.GetComponent<PlayerAttributes>().health = 100;
    }


  }
}
