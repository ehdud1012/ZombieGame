using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseRestriction : MonoBehaviour
{
    public Button DamagePurchase;
    public Button GuardPurchase;
    public Button MaxHPPurchase;
    public Button AttackRangePurchase;
    public Button BulletSpeedPurchase;
    public Button XPGainPurchase;
    public Button BulletIncreasePurchase;
    public Button HealingPurchase;
    public Button PlayerSpeedPurchase;

    public GameObject DamageSoldOut;
    public GameObject GuardSoldOut;
    public GameObject MaxHPSoldOut;
    public GameObject AttackRangeSoldOut;
    public GameObject BulletSpeedSoldOut;
    public GameObject XPGainSoldOut;
    public GameObject BulletIncreaseSoldOut;
    public GameObject HealingSoldOut;
    public GameObject PlayerSpeedSoldOut;

    public int Damage_MaxPurchase = 5;
    public int Guard_MaxPurchase = 5;
    public int MaxHP_MaxPurchase = 5;
    public int AttackRange_MaxPurchase = 5;
    public int BulletSpeed_MaxPurchase = 5;
    public int XPGain_MaxPurchase = 5;
    public int BulletIncreas_MaxPurchase = 5;
    public int Healing_MaxPurchase = 5;
    public int PlayerSpeed_MaxPurchase = 5;

    void Update()
    {
        LoadPurchaseCount();
        purchaserestriction();
    }

    private void LoadPurchaseCount()
    {
        YesButton.DamagepurchaseCount = PlayerPrefs.GetInt("DamagePurchaseCount", 0);
        YesButton.GuardpurchaseCount = PlayerPrefs.GetInt("GuardPurchaseCount", 0);
        YesButton.MaxHPpurchaseCount = PlayerPrefs.GetInt("MaxHPPurchaseCount", 0);
        YesButton.AttackRangepurchaseCount = PlayerPrefs.GetInt("AttackRangepurchaseCount", 0);
        YesButton.BulletSpeedpurchaseCount = PlayerPrefs.GetInt("BulletSpeedpurchaseCount", 0);
        YesButton.XPGainpurchaseCount = PlayerPrefs.GetInt("XPGainpurchaseCount", 0);
        YesButton.BulletIncreasepurchaseCount = PlayerPrefs.GetInt("BulletIncreasepurchaseCount", 0);
        YesButton.HealingpurchaseCount = PlayerPrefs.GetInt("HealingpurchaseCount", 0);
        YesButton.PlayerSpeedpurchaseCount = PlayerPrefs.GetInt("PlayerSpeedpurchaseCount", 0);
    }
    public void purchaserestriction()
    {
        if (YesButton.DamagepurchaseCount >= Damage_MaxPurchase)
        {
            DamagePurchase.interactable = false;
            DamageSoldOut.SetActive(true);
        }
        if (YesButton.GuardpurchaseCount >= Guard_MaxPurchase)
        {

            GuardPurchase.interactable = false;
            GuardSoldOut.SetActive(true);
        }
        if (YesButton.MaxHPpurchaseCount >= MaxHP_MaxPurchase)
        {

            MaxHPPurchase.interactable = false;
            MaxHPSoldOut.SetActive(true);
        }
        if (YesButton.AttackRangepurchaseCount >= AttackRange_MaxPurchase)
        {

            AttackRangePurchase.interactable = false;
            AttackRangeSoldOut.SetActive(true);
        }
        if (YesButton.BulletSpeedpurchaseCount >= BulletSpeed_MaxPurchase)
        {

            BulletSpeedPurchase.interactable = false;
            BulletSpeedSoldOut.SetActive(true);
        }
        if (YesButton.XPGainpurchaseCount >= XPGain_MaxPurchase)
        {

            XPGainPurchase.interactable = false;
            XPGainSoldOut.SetActive(true);
        }
        if (YesButton.BulletIncreasepurchaseCount >= BulletIncreas_MaxPurchase)
        {

            BulletIncreasePurchase.interactable = false;
            BulletIncreaseSoldOut.SetActive(true);
        }
        if (YesButton.HealingpurchaseCount >= Healing_MaxPurchase)
        {

            HealingPurchase.interactable = false;
            HealingSoldOut.SetActive(true);
        }
        if (YesButton.PlayerSpeedpurchaseCount >= PlayerSpeed_MaxPurchase)
        {

            PlayerSpeedPurchase.interactable = false;
            PlayerSpeedSoldOut.SetActive(true);
        }
    }
}
