using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public GameObject pocionVidaObject;

    public GameObject pocionXPObject;

    public void SavePlayerData(Player jugador)
    {
        PlayerPrefs.SetString("playerName", jugador.GetName());
        PlayerPrefs.SetInt("playerLevel", jugador.GetLevel());
        PlayerPrefs.SetInt("playerAttack", jugador.GetAttack());
        PlayerPrefs.SetInt("playerHP", jugador.GetHP());
        PlayerPrefs.SetInt("playerMaxHP", jugador.GetMaxHP());
        PlayerPrefs.SetInt("playerXP", jugador.GetXP());
        PlayerPrefs.SetInt("playerMaxXP", jugador.GetMaxXP());

        //Guardar lista objetos
    }

    public string LoadPlayerName()
    {
        return PlayerPrefs.GetString("playerName", "none");
    }

    public int LoadPlayerLevel()
    {
        return PlayerPrefs.GetInt("playerLevel", 1);
    }

    public int LoadPlayerAttack()
    {
        return PlayerPrefs.GetInt("playerAttack", 1);
    }

    public int LoadPlayerHP()
    {
        return PlayerPrefs.GetInt("playerHP", 20);
    }

    public int LoadPlayerMaxHP()
    {
        return PlayerPrefs.GetInt("playerMaxHP", 20);
    }

    public int LoadPlayerXP()
    {
        return PlayerPrefs.GetInt("playerXP", 0);
    }

    public int LoadPlayerMaxXP()
    {
        return PlayerPrefs.GetInt("playerMaxXP", 100);
    }

    public void SavePlayerPosition(GameObject jugadorObject)
    {
        Vector3 playerPosition = jugadorObject.transform.position;
        PlayerPrefs.SetFloat("playerX", playerPosition.x);
        PlayerPrefs.SetFloat("playerY", playerPosition.y);
        PlayerPrefs.SetFloat("playerZ", playerPosition.z);
    }

    public Vector3 LoadPlayerPosition()
    {
        return new Vector3(PlayerPrefs.GetFloat("playerX", 1f), PlayerPrefs.GetFloat("playerY", 4f), PlayerPrefs.GetFloat("playerZ", 1f) );
    }

    public void SavePlayerRotation(GameObject jugadorObject)
    {
        Quaternion playerRotation = jugadorObject.transform.rotation;
        PlayerPrefs.SetFloat("playerRX", playerRotation.x);
        PlayerPrefs.SetFloat("playerRY", playerRotation.y);
        PlayerPrefs.SetFloat("playerRZ", playerRotation.z);
        PlayerPrefs.SetFloat("playerRW", playerRotation.w);
    }

    public Quaternion LoadPlayerRotation()
    {
        return new Quaternion(PlayerPrefs.GetFloat("playerRX", 1f), PlayerPrefs.GetFloat("playerRY", 1f), PlayerPrefs.GetFloat("playerRZ", 1f), PlayerPrefs.GetFloat("playerRW", 1f));
    }

    public void SaveEnemyName(Enemy enemigo)
    {
        PlayerPrefs.SetString("enemyName", enemigo.GetName());
    }

    public string LoadEnemyName()
    {
        return PlayerPrefs.GetString("enemyName", "none");
    }

    public void SaveIsWin(bool iswin)
    {
        if (iswin)
        {
            PlayerPrefs.SetString("iswin", "true");
        }
        else 
        {
            PlayerPrefs.SetString("iswin", "false");
        }
    }

    public bool LoadIsWin()
    {
        if (PlayerPrefs.GetString("iswin", "true").Equals("true"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SaveFirstTime(bool ft)
    {
        if (ft)
        {
            PlayerPrefs.SetString("firstTime", "true");
        }
        else
        {
            PlayerPrefs.SetString("firstTime", "false");
        }
    }

    public bool LoadFirstTime()
    {
        if (PlayerPrefs.GetString("firstTime", "true").Equals("true"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SaveStopCircles(string value)
    {
        PlayerPrefs.SetString("stopCircles", value);
    }

    public string LoadStopCircles()
    { 
        return PlayerPrefs.GetString("stopCircles", "true");
    }

    public void SaveLastEnemy(string value)
    {
        PlayerPrefs.SetString("lastEnemy", value);
    }

    public string LoadLastEnemy()
    {
        return PlayerPrefs.GetString("lastEnemy", "true");
    }


    public void SaveListaObjetos(List<PickUp> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            PlayerPrefs.SetString("item" + i, lista[i].name);
        }
        PlayerPrefs.SetInt("listaCounter", lista.Count);
    }

    public List<PickUp> LoadListaObjetos()
    {
        List<PickUp> nuevaLista = new List<PickUp>();    
        PickUp nuevoItem;
        int counter = PlayerPrefs.GetInt("listaCounter", 0);
        for (int i = 0; i < counter; i++)
        {
            nuevaLista.Add(LoadItem(PlayerPrefs.GetString("item" + i, "none")));
        }
        return nuevaLista;
    }

    PickUp LoadItem(string nombre)
    {
        if (nombre.Equals("PocionVida"))
        {
            return pocionVidaObject.GetComponent<PickUp>();
        }
        else if (nombre.Equals("PocionXP"))
        {
            return pocionXPObject.GetComponent<PickUp>();
        }
        else
        {
            return null;
        }
    }
    public void ResetListaObjetos()
    {
        PlayerPrefs.SetString("item1", "none");
        PlayerPrefs.SetString("item2", "none");
        PlayerPrefs.SetString("item3", "none");
        PlayerPrefs.SetString("item4", "none");
        PlayerPrefs.SetString("item5", "none");
        PlayerPrefs.SetString("item6", "none");
        PlayerPrefs.SetString("item7", "none");
        PlayerPrefs.SetString("item8", "none");
        PlayerPrefs.SetString("item9", "none");
        PlayerPrefs.SetString("item10", "none");
        PlayerPrefs.SetString("item11", "none");
        PlayerPrefs.SetString("item12", "none");
        PlayerPrefs.SetString("item13", "none");
        PlayerPrefs.SetString("item14", "none");
        PlayerPrefs.SetString("item15", "none");
        PlayerPrefs.SetInt("listaCounter", 0);
    }

    public void SaveSiguienteConversacion(int siguiente)
    {
        PlayerPrefs.SetInt("siguienteConversacion", siguiente);
    }

    public int LoadSiguienteConversacion()
    {
       return PlayerPrefs.GetInt("siguienteConversacion", 0);
    }

    public void SaveMisionCompletada(bool completada)
    {
        if (completada)
        {
            PlayerPrefs.SetString("misionCompletada", "true");
        }
        else 
        {
            PlayerPrefs.SetString("misionCompletada", "false");
        }
        
    }

    public bool LoadMisionCompletada()
    {
        if (PlayerPrefs.GetString("misionCompletada", "true").Equals("true"))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    //---------------------------------------------------------------------Pociones de vida
    public void SaveHP1(string value)
    {
        PlayerPrefs.SetString("hp1", value);
    }

    public string LoadHP1()
    {
        return PlayerPrefs.GetString("hp1", "true");
    }

    public void SaveHP2(string value)
    {
        PlayerPrefs.SetString("hp2", value);
    }

    public string LoadHP2()
    {
        return PlayerPrefs.GetString("hp2", "true");
    }

    public void SaveHP3(string value)
    {
        PlayerPrefs.SetString("hp3", value);
    }

    public string LoadHP3()
    {
        return PlayerPrefs.GetString("hp3", "true");
    }



    //---------------------------------------------------------------------Pociones de experiencia
    public void SaveXP1(string value)
    {
        PlayerPrefs.SetString("xp1", value);
    }

    public string LoadXP1()
    {
        return PlayerPrefs.GetString("xp1", "true");
    }

    public void SaveXP2(string value)
    {
        PlayerPrefs.SetString("xp2", value);
    }

    public string LoadXP2()
    {
        return PlayerPrefs.GetString("xp2", "true");
    }

    //---------------------------------------------------------------------Champimudos
    public void SaveCh1(string value)
    {
        PlayerPrefs.SetString("ch1", value);
    }

    public string LoadCh1()
    {
        return PlayerPrefs.GetString("ch1", "true");
    }

    public void SaveCh2(string value)
    {
        PlayerPrefs.SetString("ch2", value);
    }

    public string LoadCh2()
    {
        return PlayerPrefs.GetString("ch2", "true");
    }

    public void SaveCh3(string value)
    {
        PlayerPrefs.SetString("ch3", value);
    }

    public string LoadCh3()
    {
        return PlayerPrefs.GetString("ch3", "true");
    }

    public void SaveCh4(string value)
    {
        PlayerPrefs.SetString("ch4", value);
    }

    public string LoadCh4()
    {
        return PlayerPrefs.GetString("ch4", "true");
    }

    public void SaveCh5(string value)
    {
        PlayerPrefs.SetString("ch5", value);
    }

    public string LoadCh5()
    {
        return PlayerPrefs.GetString("ch5", "true");
    }


    //---------------------------------------------------------------------Champimudos furiosos
    public void SaveChF1(string value)
    {
        PlayerPrefs.SetString("chf1", value);
    }

    public string LoadChF1()
    {
        return PlayerPrefs.GetString("chf1", "true");
    }

    public void SaveChF2(string value)
    {
        PlayerPrefs.SetString("chf2", value);
    }

    public string LoadChF2()
    {
        return PlayerPrefs.GetString("chf2", "true");
    }

    public void SaveChF3(string value)
    {
        PlayerPrefs.SetString("chf3", value);
    }

    public string LoadChF3()
    {
        return PlayerPrefs.GetString("chf3", "true");
    }

    public void SaveChF4(string value)
    {
        PlayerPrefs.SetString("chf4", value);
    }

    public string LoadChF4()
    {
        return PlayerPrefs.GetString("chf4", "true");
    }

    public void SaveChF5(string value)
    {
        PlayerPrefs.SetString("chf5", value);
    }

    public string LoadChF5()
    {
        return PlayerPrefs.GetString("chf5", "true");
    }


    //---------------------------------------------------------------------Florhadas
    public void SaveFh1(string value)
    {
        PlayerPrefs.SetString("fh1", value);
    }

    public string LoadFh1()
    {
        return PlayerPrefs.GetString("fh1", "true");
    }

    public void SaveFh2(string value)
    {
        PlayerPrefs.SetString("fh2", value);
    }

    public string LoadFh2()
    {
        return PlayerPrefs.GetString("fh2", "true");
    }

    public void SaveFh3(string value)
    {
        PlayerPrefs.SetString("fh3", value);
    }

    public string LoadFh3()
    {
        return PlayerPrefs.GetString("fh3", "true");
    }

    public void SaveFh4(string value)
    {
        PlayerPrefs.SetString("fh4", value);
    }

    public string LoadFh4()
    {
        return PlayerPrefs.GetString("fh4", "true");
    }

    public void SaveFh5(string value)
    {
        PlayerPrefs.SetString("fh5", value);
    }

    public string LoadFh5()
    {
        return PlayerPrefs.GetString("fh5", "true");
    }


    //---------------------------------------------------------------------Trifauces
    public void SaveTr1(string value)
    {
        PlayerPrefs.SetString("tr1", value);
    }

    public string LoadTr1()
    {
        return PlayerPrefs.GetString("tr1", "true");
    }

    //---------------------------------------------------------------------Scarab
    public void SaveSc1(string value)
    {
        PlayerPrefs.SetString("sc1", value);
    }

    public string LoadSc1()
    {
        return PlayerPrefs.GetString("sc1", "true");
    }

}
