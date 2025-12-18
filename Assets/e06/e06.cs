//using Unity.VisualScripting;
using UnityEngine;

public class e06 : MonoBehaviour
{
  public int numberA;
  public int numberB;
  public int numberC;

  void Start()
{
    int average = numberA + numberB + numberC / 3;
    Debug.Log("El promedio es: " + average);
 }

}
