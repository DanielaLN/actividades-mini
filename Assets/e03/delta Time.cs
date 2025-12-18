using UnityEngine;

public class DeltaTimePrinter:MonoBehaviour
{
    //este método se llama una vez por frame
    void Update ()
    {
        //imprime el deltaTime en la consola 
        Debug.Log("Delta Time: " + Time.deltaTime);
    }

}
