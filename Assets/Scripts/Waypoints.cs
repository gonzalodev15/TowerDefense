using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points = new Transform[22];
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Awake()
    {
        WithForLoop();
    }

    void WithForLoop()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; ++i)
            points[i] = transform.GetChild(i);
    }
}
