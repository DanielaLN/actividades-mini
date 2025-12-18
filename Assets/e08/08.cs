using UnityEngine;

public class e08 : MonoBehaviour

{
    public float numero;
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            float resultado = numero * i;
            // aqui va la línea que mostrará la multiplicación
            Debug.Log(numero + "x" + i + " = " + resultado);
        }
    }
}
