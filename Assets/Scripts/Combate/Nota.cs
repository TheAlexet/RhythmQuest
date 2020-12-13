﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{
    Vector3 posicionFinal;

    GameObject jugadorObject;
    Combate combate;

    public GameObject databaseObject;
    Database database;

    void Start()
    {
        databaseObject = GameObject.Find("Database");
        database = databaseObject.GetComponent<Database>();
        posicionFinal = new Vector3(60f, 2.58f, 60.17314f);
   
        jugadorObject = GameObject.Find("Activator");
        combate = jugadorObject.GetComponent<Combate>();
    }

    void Update()
    {
        if (database.LoadStopCircles().Equals("false"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 4);
            if (this.gameObject.transform.position.x > 60f)
            {
                Destroy(this.gameObject);
                combate.NotaFallada();
            }
        }

    }
}