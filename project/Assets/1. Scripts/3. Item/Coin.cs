using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coin : MonoBehaviour
{
    public static int CoinCount;

    private void Awake()
    {
        CoinCount = 0;
    }
}