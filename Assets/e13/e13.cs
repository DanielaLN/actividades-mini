using UnityEngine;

public class e13 : MonoBehaviour 
{
    public int min = 0;
    public int max = 10;

    void Start() 
    {
        int count = 0;

        while (count < 100) 
        {
           int randomValue = Random.Range(min, max);
            Debug.Log(randomValue);

            count = count + 1;  
        }
    }
}
