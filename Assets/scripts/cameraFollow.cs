using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objetivo que la cámara seguirá
    public float offsety = 0f; // Desplazamiento vertical de la cámara
   
    private void LateUpdate()
    {
        // solo sigue al jugador en el eje x, manteniendo la posición y y z de la cámara
        transform.position = new Vector3(target.position.x, offsety, transform.position.z);
    }
}
