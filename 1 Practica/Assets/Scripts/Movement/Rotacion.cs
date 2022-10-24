using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float time;
    public float y = 5;
    public float x = 5;
    public float z = 5;

    public float ScaleSpeed = 1;

    public float movingSpeed;

    private void Update()
    {
        transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);

        transform.localScale += new Vector3(ScaleSpeed * Time.deltaTime, ScaleSpeed * Time.deltaTime, ScaleSpeed * Time.deltaTime);

        transform.position += transform.forward * Time.deltaTime * movingSpeed;
    }
}