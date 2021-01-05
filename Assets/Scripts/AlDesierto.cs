﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlDesierto : MonoBehaviour
{

    public GameObject databaseObject;
    Database database;

    void Start()
    {
        database = databaseObject.GetComponent<Database>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            database.SaveFirstTime2(true);
            SceneManager.LoadScene("Desierto Espejismo");
        }

    }
}
