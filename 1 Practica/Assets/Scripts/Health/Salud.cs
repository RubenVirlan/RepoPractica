using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salud : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;
    private Vector3 InitialPosition;
    public Text HealthText;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        HealthText.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        HealthText.text = currentHealth.ToString();

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