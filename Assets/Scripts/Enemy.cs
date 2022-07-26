using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;
    private Transform target;
    private int waypointindex = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (waypointindex == Waypoints.points.Length)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            return;
        }

        if (Vector3.Distance(transform.position, target.position) < 0.4)
        {
            target = getNextTarget();
        }
    }

    Transform getNextTarget()
    {
        if (waypointindex < Waypoints.points.Length)
            waypointindex += 1;

        if(waypointindex >= Waypoints.points.Length)
            return Waypoints.points[Waypoints.points.Length-1];
        else
            return Waypoints.points[waypointindex];
    }
}
