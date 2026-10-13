using UnityEngine;

public class ColorZone : MonoBehaviour {
  public Color colorInside = Color.orange;
  private Renderer[] renderers;
  private Color[] colorOriginals;

  void OnTriggerEnter(Collider other) {
    renderers = other.GetComponentsInChildren<Renderer>();
    colorOriginals = new Color[renderers.Length];
    for (int i = 0; i < renderers.Length; i++) {
      colorOriginals[i] = renderers[i].material.color;
      renderers[i].material.color = colorInside;
    }
  }

  void OnTriggerExit(Collider other) {
    for (int i = 0; i < renderers.Length; i++) {
      if (renderers[i] != null)
        renderers[i].material.color = colorOriginals[i];
    }
  }
}