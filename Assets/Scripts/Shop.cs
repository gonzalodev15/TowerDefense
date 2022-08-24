using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text currency;

    public void selectStandardTurret()
    {

        float currentCurrency = float.Parse(currency.text);
        if(currentCurrency >= 150)
        {
            TurretManager.instance.setTurret(TurretManager.instance.standardTurret);
        }
    }

    public void selectMissileTurret()
    {
        TurretManager.instance.setTurret(TurretManager.instance.missileTurret);
    }
}
