using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : PLayerTriger
{
    public Transform targetPosition;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        playerObject.transform.position = targetPosition.position;
    }
}