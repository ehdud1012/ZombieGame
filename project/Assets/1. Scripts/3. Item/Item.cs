using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public float rotateSpeed;
    public static int AccumulatedCoin;
    public static int count = 1;

    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Coin.CoinCount += count;
            gameObject.SetActive(false);

            AccumulatedCoin = PlayerPrefs.GetInt("AccumulatedCoin", 0) + count;
            PlayerPrefs.SetInt("AccumulatedCoin", AccumulatedCoin);

            Debug.Log("누적 코인 : " + Item.AccumulatedCoin);
        }
    }
}
