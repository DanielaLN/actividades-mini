using UnityEngine;

public class e16:MonoBehaviour
{
    public float speed = 5f; // Units per second
    void Update()
    {
        // Move diagonally: +X (right) and -Y (down) in screen space
        Vector3 direction = new Vector3(1f, -1f, 0f).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
        //nose como hacer que rebote y se quede dentro de la pantalla
    }
}
