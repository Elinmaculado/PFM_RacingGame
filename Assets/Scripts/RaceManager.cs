using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class RaceManager : NetworkBehaviour
{
    public int currentLap = 0;

    private List<PrometeoCarController> registeredPlayers = new();

    public void RegisterPlayer(PrometeoCarController player)
    {
        if (!isServer) return;

        registeredPlayers.Add(player);

        if (registeredPlayers.Count == 1)
        {
            player.playerNumber = "Player1";
            Debug.Log("Entró el jugador 1");
        }
        else if (registeredPlayers.Count == 2)
        {
            player.playerNumber = "Player2"; 
            Debug.Log("Entró el jugador 2");
        }

        Debug.Log($"Jugador registrado: {player.netId}, Asignado como: {player.playerNumber}");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
