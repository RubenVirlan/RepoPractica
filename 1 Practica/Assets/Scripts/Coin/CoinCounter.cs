using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOfCoin;
    public Text caunterCoin;

    public void GetCoins(int cointAmount)
    {
        currentNumberOfCoin += cointAmount;
        Debug.Log("He ecnontrado una moneda y tengo " + currentNumberOfCoin + " monedas.");
        caunterCoin.text = currentNumberOfCoin.ToString();
    }
}