using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretManager : MonoBehaviour
{
    public static TurretManager instance;
    public GameObject currentTurret;
    public GameObject standardTurret;
    public GameObject missileTurret;
    public CurrencyManager currencyManager;
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
        if(canBuild())
        {
            return currentTurret;
        }

        return null;
    }

    public void setTurret(GameObject turret)
    {
        currentTurret = turret;
    }

    public bool canBuild()
    {
        if(currentTurret == standardTurret)
        {
            float currentCurrency = currencyManager.getCurrency();
            if (currentCurrency >= 150)
            {
                currencyManager.substractMoney(150);
                return true;
            }
        }

        if (currentTurret == missileTurret)
        {
            float currentCurrency = currencyManager.getCurrency();
            if (currentCurrency >= 200)
            {
                currencyManager.substractMoney(200);
                return true;
            }
        }
        return false;
    }
}
