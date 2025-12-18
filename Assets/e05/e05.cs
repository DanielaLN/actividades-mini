using System.Runtime.CompilerServices;
using UnityEngine;

public class e05 : MonoBehaviour
{
    public int numberA; 
    public int numberB;
    void Start()
    {
        int sum = numberA + numberB;
        Debug.Log("La suma de " + numberA + " y " + numberB + " es: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
