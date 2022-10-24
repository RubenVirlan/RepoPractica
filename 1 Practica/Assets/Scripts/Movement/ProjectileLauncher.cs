using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject projectilePrefabs;
    public float timetoShoot = 1;
    private float timeSinceLastShoot;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;

        if (timeSinceLastShoot >= timetoShoot)
        {
            Instantiate(projectilePrefabs, shootPoint.position, shootPoint.rotation);
            timeSinceLastShoot = 0;
        }
    }
}