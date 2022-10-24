using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;
    private Vector3 InitialPosition;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            Debug.Log("Has Muerto");
            transform.position = InitialPosition;
            currentHealth = MaxHealth;
        }
        else
        {
            Debug.Log("Has sufrido daños, te quedan " + currentHealth + " de vida");
        }
    }
}