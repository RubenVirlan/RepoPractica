using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerTriger : MonoBehaviour
{
    private string playertag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playertag))
        {
            OnPlayerEnter(other.gameObject);
        }
    }

    public virtual void OnPlayerEnter(GameObject playerObject)
    {
    }
}