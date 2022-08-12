using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float movementSpeed = 10f;
    private float min = 10;
    private float max = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * Time.deltaTime * movementSpeed, Space.World);
        }
        if (Input.GetKey("x"))
        {
            transform.Translate(Vector3.down * Time.deltaTime * movementSpeed, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed, Space.World);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed, Space.World);
        }
    }
}
