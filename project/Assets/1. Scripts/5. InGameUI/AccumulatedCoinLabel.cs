using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccumulatedCoinLabel : MonoBehaviour
{
    Text accumulatedcoinLabel;
    void Start()
    {
        accumulatedcoinLabel = GetComponent<Text>();
        Item.AccumulatedCoin = PlayerPrefs.GetInt("AccumulatedCoin", 0);
    }

    void Update()
    {
        accumulatedcoinLabel.text = ("" + Item.AccumulatedCoin.ToString());
    }
}
