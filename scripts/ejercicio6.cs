using UnityEngine;

public class EsferaHaciaObjetivo : MonoBehaviour {
  public Transform cilindro;  
  public Transform cubo;           
  public Material materialNuevo;   
  public float velocidad = 3f;
  public float distanciaChoque = 3f; 
  private bool changedCube = false;

    void Update() {
      Vector3 direction = (cilindro.position - transform.position).normalized;
      transform.position += direction * velocidad * Time.deltaTime;
      if (!changedCube) {
        float distance = Vector3.Distance(transform.position, cubo.position);
        if (distance < distanciaChoque) {
            ChangeCubeMaterial();
        }
      }
    }

    void ChangeCubeMaterial() {
      Renderer rend = cubo.GetComponent<Renderer>();
      rend.material = materialNuevo;   
      changedCube = true;
    }
}