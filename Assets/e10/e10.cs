using UnityEngine;

public class e10 :MonoBehaviour
{
    void Start() 
    {
        float numberA = Random.Range(-10f, 10f);
        float numberB = Random.Range(-10f, 10f);

        int operation = Random.Range(0, 5);

        float result = 0f;
        string symbol = "";

        if ((operation == 3 || operation == 4) && Mathf.Approximately (numberB, 0f))
        {
            numberB = Random.Range(1f, 10f); // Garantizamos que no sea cero
        }
        if (operation == 0)
        {
            //suma
            result = numberA + numberB;
            symbol = "+";
        }
        else if (operation == 1)
        {
           //resta
            result = numberA - numberB;
            symbol = "-";
        }
        else if (operation == 2)
        {
            //multiplicación
            result = numberA * numberB;
            symbol = "*";
        }
        else if (operation == 3) 
        {
            //división
            result = numberA / numberB;
            symbol = "/";
        }
        else if (operation == 4) 
        {
            //módulo
            result = numberA % numberB;
            symbol = "%";
        }
       
        {
          
            // Enviar una sol vez a la consola de Unity
            Debug.Log(numberA + " " + symbol + " " + numberB + " = " + result);
        }
    }
}


