﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public void selectStandardTurret()
    {
        TurretManager.instance.setTurret(TurretManager.instance.standardTurret);
    }

    public void selectMissileTurret()
    {
        TurretManager.instance.setTurret(TurretManager.instance.standardTurret);
    }
}
