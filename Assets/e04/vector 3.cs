using UnityEngine;

public class PrintVector3 : MonoBehaviour
{
    // Este vector3 será configurable desde el Inspector
    public Vector3 vectorToPrint;

    //Este método se ejecuta una vez al iniciar el juego 
    void Start() 
    { 
        // Imprime el Vector3 en la consola 
        Debug.Log("El Vector3 configurado es: " + vectorToPrint);
    }
}
