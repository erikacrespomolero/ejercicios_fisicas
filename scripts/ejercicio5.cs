using UnityEngine;

public class ThrowObject : MonoBehaviour {
public Rigidbody objetive;
public float fuerza = 1f;

void Update() {
  if (Input.GetKeyDown(KeyCode.X)) {
    objetive.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
  }
}
}
