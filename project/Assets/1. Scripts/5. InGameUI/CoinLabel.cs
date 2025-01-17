using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinLabel : MonoBehaviour
{
    Text coinLabel;
    void Start()
    {
        coinLabel = GetComponent<Text>();
    }

    void Update()
    {
        coinLabel.text = ("" + Coin.CoinCount.ToString());
    }
}
