using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretManager : MonoBehaviour
{
    public static TurretManager instance;
    public GameObject currentTurret;
    public GameObject standardTurret;
    public GameObject missileTurret;
    //public GameObject standardTurret;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Error: instance already created");
            return;
        }
        instance = this;
    }

    public GameObject getCurrentTurret()
    {
        return currentTurret;
    }

    public void setTurret(GameObject turret)
    {
        currentTurret = turret;
    } 
}
