﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNotaNaranja : MonoBehaviour
{
    public GameObject Nota;

    public void Spawn()
    {
        Instantiate(Nota, transform.position, Quaternion.identity);
    }
}
