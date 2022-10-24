using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovientoColumnas : MonoBehaviour
{
    public float movementSpeed = 5;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
        transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
}