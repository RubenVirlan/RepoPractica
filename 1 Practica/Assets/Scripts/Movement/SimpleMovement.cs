using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moventSpeed = 0;

    private void Update()
    {
        transform.position += transform.forward * moventSpeed * Time.deltaTime;
    }
}