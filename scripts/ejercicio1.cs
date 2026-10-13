using UnityEngine;

public class MoveCharacter : MonoBehaviour {
  public float speed = 1;
  private Vector3 input;
  private Rigidbody rb;

  void Awake() {
    rb = GetComponent<Rigidbody>();
    rb.isKinematic = true;
  }

  void Update() {
    input = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
    input = input.normalized;
  }

  void FixedUpdate() {
    Vector3 newPosition = rb.position + input * speed * Time.fixedDeltaTime;
    rb.MovePosition(newPosition);
  }
}