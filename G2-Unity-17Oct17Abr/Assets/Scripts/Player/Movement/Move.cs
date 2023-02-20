using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  [SerializeField] private InputController input = null;
  [SerializeField, Range(0f, 100f)] private float maxSpeed = 4f;
  [SerializeField, Range(0f, 100f)] private float maxAcceleration = 35f;
  [SerializeField, Range(0f, 100f)] private float maxAirAcceleration = 20f;

  private Vector2 direction;
  private Vector2 desiredVelocity;
  private Vector2 velocity;
  private Rigidbody2D rb;
  private Ground ground;

  private float maxSpeedChange;
  private float acceleration;
  private bool onGround;

  private void Awake()
  {
    rb = GetComponent<Rigidbody2D>();
    ground = GetComponent<Ground>();
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    direction.x = input.RetrieveMoveInput();
    desiredVelocity = new Vector2(direction.x, 0f) * Mathf.Max(maxSpeed - ground.GetFriction(), 0f);
  }

  private void FixedUpdate()
  {
    onGround = ground.GetOnGround();
    velocity = rb.velocity;
    // Condicion - Resultado else resultado
    acceleration = onGround ? maxAcceleration : maxAirAcceleration;
    maxSpeedChange = acceleration * Time.deltaTime;
    velocity.x = Mathf.MoveTowards(velocity.x, desiredVelocity.x, maxSpeedChange);

    rb.velocity = velocity;
  }
}
