using UnityEngine;

public class DetectorColision : MonoBehaviour {
  void OnCollisionEnter(Collision collision) {
    Debug.Log(gameObject.name + " colisionó con: " + collision.gameObject.name);
    Renderer rend = GetComponent<Renderer>();
    rend.material.color = Random.ColorHSV(); 
  }
}