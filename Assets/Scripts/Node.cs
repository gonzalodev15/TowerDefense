using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    private Renderer rend;
    private Color startColor;
    private GameObject turret;

    //public GameObject turretPrefab;
    private TurretManager turretManager;
    public Turret manager;
    private float turretOffset = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        rend.material.color = Color.white;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;

    }

    private void OnMouseDown()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (turret == null)
        {
            GameObject currentTurret = TurretManager.instance.getCurrentTurret();
            if (currentTurret == null) {
                return;
            }
            turret = (GameObject) Instantiate(currentTurret, transform.position + new Vector3(0, turretOffset, 0), transform.rotation);
        } 
    }
}
