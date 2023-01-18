using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class <c> PlayerController </c> is in charge of allowing to control the player but it has a special 
/// feature to be a pet (Simple IA).
/// </summary>
public class PlayerController : MonoBehaviour
{
  /// <summary>
  /// This variable is in charge of changing the type of movement.
  /// </summary>
  public bool IsPet = false;

  /// <summary>
  /// This variable ( <c> MoveSpeed </c> ) is in charge of the movement of the 
  /// object. </summary>
  public float MoveSpeed = 5f;

  /// <summary>
  /// <c> Limit Area </c> is in charge of setting a range betweeen the original 
  /// position and the target. </summary>
  public float LimitArea = 0.05f;

  /// <summary>
  /// Test
  /// </summary>
  public Transform MovePoint;

  public int Health = 100;

  // Start is called before the first frame update
  void Start()
  {
    MovePoint.parent = null;
  }

  // Update is called once per frame
  void Update()
  {
    if (MovePoint.gameObject.GetComponent<MovePointDetection>().IsObjectNear == false)
    {
      Move();
    }
    else
    {
      transform.position -= new Vector3(1, 0, 0);
      MovePoint.position = transform.position;
      MovePoint.gameObject.GetComponent<MovePointDetection>().IsObjectNear = false;
    }
  }

  /// <summary> This method is in charge of the movement of the object.
  /// <example>
  /// For example: 
  /// <code>
  ///    transform.position = MoveTowards(OwnPosition, TargetPosition, Speed * Time);
  ///    transform.position = MoveTowards(OwnPosition, TargetPosition, Speed * Time);
  /// </code>
  /// Returns a new move position.
  /// </example>
  /// </summary>
  void Move()
  {
    float x = Input.GetAxisRaw("Horizontal");
    float y = Input.GetAxisRaw("Vertical");

    // Aplicamos el movimiento hacia la posicion deseada
    transform.position = Vector3.MoveTowards(transform.position, MovePoint.position, MoveSpeed * Time.deltaTime);

    if (Vector3.Distance(transform.position, MovePoint.position) <= LimitArea)
    {
      if (IsPet == false)
      {
        // Movimiento en horizontal definido por absolutos (+, -)
        if (Mathf.Abs(x) == 1)
        {
          MovePoint.position += new Vector3(x, 0f, 0f);
        }

        // Movimiento en vertical definido por absolutos (+, -)
        if (Mathf.Abs(y) == 1)
        {
          MovePoint.position += new Vector3(0f, y, 0f);
        }
      }
    }
  }

  /// <summary>
  /// This method
  /// </summary>
  /// <param name="health">This Parameter is in charge of giving a new value forthe health.</param>
  public void SetHealth(int health)
  {
    int tmpHealth = health;
  }

  private void OnDrawGizmosSelected()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, LimitArea);

    Gizmos.color = Color.green;
    Gizmos.DrawLine(transform.position, MovePoint.position);
  }
}
