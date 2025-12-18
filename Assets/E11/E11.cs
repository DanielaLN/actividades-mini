using UnityEngine;

public class E11 : MonoBehaviour
{
    // 1 = piedra, 2 = papel, 3 = tijera
    public int playerA;
    public int playerB;
    public int numeroDeRondas = 5;
    void Start()
    {
        if (numeroDeRondas <= 0)
            numeroDeRondas = 1;
        for (int ronda = 1; ronda <= numeroDeRondas; ronda++)
        {
            playerB = Random.Range(1, 4); // 1, 2, 3
            string resultado = CalcularResultado (playerA, playerB);
            Debug.Log($"Ronda {ronda}:" +
                        $"playerA = {NombreJugada(playerA)}, " +
                        $"playerB = {NombreJugada(playerB)} => {resultado}");
        }
        }
    string NombreJugada(int valor)
    {
        if (valor == 1)
        {
            return "Piedra";
        }
        else if (valor == 2)
        {
            return "Papel";
        }
        else if (valor == 3)
        {
            return "Tijera";
        }
        return "Desconocido";
    }
    string CalcularResultado(int a, int b)
    {     if (a == b)
            return "Draw"; 
          if (a == 1 && b == 2) return "Player B Wins";
          if (a == 1 && b == 3) return "Player A Wins";
          if (a == 2 && b == 1) return "Player A Wins";
          if (a == 2 && b == 3) return "Player B Wins";
          if (a == 3 && b == 1) return "Player B Wins";
          if (a == 3 && b == 2) return "Player A Wins";
        
          return "Valores inválidos";
    }
    }