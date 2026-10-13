using UnityEngine;

public class HarmZone : MonoBehaviour {
  public int harm = 0;

  void OnTriggerEnter(Collider other) {
    harm += 1;
  }
}