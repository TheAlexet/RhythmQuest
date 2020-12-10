using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFija : MonoBehaviour
{
        
    // La camara sigue al jugador
    void Update()
    {
        Vector3 PlayerPOS = GameObject.Find("Player").transform.transform.position;
        GameObject.Find("Main Camera").transform.position = new Vector3(PlayerPOS.x + 5, PlayerPOS.y + 5, PlayerPOS.z);
    }
}
