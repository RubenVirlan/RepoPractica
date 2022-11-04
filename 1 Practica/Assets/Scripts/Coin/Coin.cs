using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Coin : PlayerTrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        CoinCounter coinCounter = playerObject.GetComponent<CoinCounter>();
        coinCounter.GetCoins(amountToGive);
        gameObject.SetActive(false);
    }
}