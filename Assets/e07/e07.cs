using UnityEngine;

public class e07 : MonoBehaviour
{
    public float numberA;
    public float numberB;
    public string operation;

    private void Start()
    {
        float result; 

        switch (operation)
        {
            case "+":
                result = numberA + numberB;
                break;
            case "-":   
                result = numberA - numberB;
                break;
            case "*":
                result = numberA * numberB;
                break;
            case "/":
                result = numberA / numberB; 
                break;
            case "%":
                result = numberA % numberB; 
                break;

            default: 
                Debug.Log("Operación no válida");
                return; 
        }
        Debug.Log("Resultado: " + result);
        }
    }