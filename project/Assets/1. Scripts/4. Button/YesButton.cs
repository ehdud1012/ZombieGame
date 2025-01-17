using UnityEngine;
using UnityEngine.UI;

public class YesButton : MonoBehaviour
{
    public GameObject NoPurchase;

    public static int DamagepurchaseCount = 0;
    public static int GuardpurchaseCount = 0;
    public static int MaxHPpurchaseCount = 0;
    public static int AttackRangepurchaseCount = 0;
    public static int BulletSpeedpurchaseCount = 0;
    public static int XPGainpurchaseCount = 0;
    public static int BulletIncreasepurchaseCount = 0;
    public static int HealingpurchaseCount = 0;
    public static int PlayerSpeedpurchaseCount = 0;

    private int DamagePrice = 100;
    private int GuardPrice = 200;
    private int MaxHPPrice = 100;
    private int AttackRangePrice = 150;
    private int BulletSpeedPrice = 150;
    private int XPGainPrice = 300;
    private int BulletIncreasePrice = 1500;
    private int HealingPrice = 100;
    private int PlayerSpeedPrice = 150;

    public static float AccumulatedDamage = PlayerStats.baseDamage;
    public static float AccumulatedGuard = PlayerStats.baseGuard;
    public static float AccumulatedMaxHP = PlayerStats.baseMaxHP;
    public static float AccumulatedAttackRange = PlayerStats.baseAttackRange;
    public static float AccumulatedBulletSpeed = PlayerStats.baseBulletSpeed;
    public static float AccumulatedXPGain = PlayerStats.baseExperienceGain;
    public static float AccumulatedBulletIncrease = PlayerStats.baseBulletCount;
    public static float AccumulatedHealing = PlayerStats.baseHealing;
    public static float AccumulatedPlayerSpeed = PlayerStats.basePlayerSpeed;


    private void SavePurchaseCount()
    {
        PlayerPrefs.SetInt("DamagePurchaseCount", DamagepurchaseCount);
        PlayerPrefs.SetInt("GuardPurchaseCount", GuardpurchaseCount);
        PlayerPrefs.SetInt("MaxHPPurchaseCount", MaxHPpurchaseCount);
        PlayerPrefs.SetInt("AttackRangepurchaseCount", AttackRangepurchaseCount);
        PlayerPrefs.SetInt("BulletSpeedpurchaseCount", BulletSpeedpurchaseCount);
        PlayerPrefs.SetInt("XPGainpurchaseCount", XPGainpurchaseCount);
        PlayerPrefs.SetInt("BulletIncreasepurchaseCount", BulletIncreasepurchaseCount);
        PlayerPrefs.SetInt("HealingpurchaseCount", HealingpurchaseCount);
        PlayerPrefs.SetInt("PlayerSpeedpurchaseCount", PlayerSpeedpurchaseCount);
    }
    private void LoadPurchaseCount()
    {
        DamagepurchaseCount = PlayerPrefs.GetInt("DamagePurchaseCount", 0);
        GuardpurchaseCount = PlayerPrefs.GetInt("GuardpurchaseCount", 0);
        MaxHPpurchaseCount = PlayerPrefs.GetInt("MaxHPpurchaseCount", 0);
        AttackRangepurchaseCount = PlayerPrefs.GetInt("AttackRangepurchaseCount", 0);
        BulletSpeedpurchaseCount = PlayerPrefs.GetInt("BulletSpeedpurchaseCount", 0);
        XPGainpurchaseCount = PlayerPrefs.GetInt("XPGainpurchaseCount", 0);
        BulletIncreasepurchaseCount = PlayerPrefs.GetInt("BulletIncreasepurchaseCount", 0);
        HealingpurchaseCount = PlayerPrefs.GetInt("HealingpurchaseCount", 0);
        PlayerSpeedpurchaseCount = PlayerPrefs.GetInt("PlayerSpeedpurchaseCount", 0);
    }
    public void DamageButtonClick()
    {
        if (Item.AccumulatedCoin > DamagePrice)
        {
            DamagepurchaseCount++;
            SavePurchaseCount();
            Debug.Log("������ ���� Ƚ�� : " + YesButton.DamagepurchaseCount);
            PlayerStats.DamageCurLevel++;

            PlayerStats.baseDamage = PlayerPrefs.GetFloat("AccumulatedDamage", AccumulatedDamage);
            PlayerStats.baseDamage += PlayerStats.DamageIncrease;

            Item.AccumulatedCoin -= DamagePrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + DamagePrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");

            AccumulatedDamage = PlayerStats.baseDamage; // ���� �������� ���� �������� ������Ʈ
            PlayerPrefs.SetFloat("AccumulatedDamage", AccumulatedDamage);

            Debug.Log("������ ���� : " + PlayerStats.DamageCurLevel);
            Debug.Log("�Ѿ� ���ط� : " + PlayerStats.baseDamage);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }
    }

    public void GuardButtonClick()
    {
        if (Item.AccumulatedCoin > GuardPrice)
        {
            GuardpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("���� ���� Ƚ�� : " + YesButton.GuardpurchaseCount);

            PlayerStats.GuardCurLevel++;
            PlayerStats.baseGuard = PlayerPrefs.GetFloat("AccumulatedGuard", AccumulatedGuard);
            PlayerStats.baseGuard -= PlayerStats.GuardIncrease;

            Item.AccumulatedCoin -= GuardPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + GuardPrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");


            AccumulatedGuard = PlayerStats.baseGuard;
            PlayerPrefs.SetFloat("AccumulatedGuard", AccumulatedGuard);

            Debug.Log("���� ���� : " + PlayerStats.GuardCurLevel);
            Debug.Log("�� ���ط� : " + PlayerStats.baseGuard);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");

        }
    }
    public void MaxHPButtonClick()
    {
        if (Item.AccumulatedCoin > MaxHPPrice)
        {
            MaxHPpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("HP ���� Ƚ�� : " + YesButton.MaxHPpurchaseCount);

            PlayerStats.MaxHPCurLevel++;
            PlayerStats.baseMaxHP = PlayerPrefs.GetFloat("AccumulatedMaxHP", AccumulatedMaxHP);
            PlayerStats.baseMaxHP += PlayerStats.MaxHPIncrease;

            Item.AccumulatedCoin -= MaxHPPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + MaxHPPrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");

            AccumulatedMaxHP = PlayerStats.baseMaxHP;
            PlayerPrefs.SetFloat("AccumulatedMaxHP", AccumulatedMaxHP);

            Debug.Log("�ִ�ü�� ���� : " + PlayerStats.MaxHPCurLevel);
            Debug.Log("�ִ� ü�� : " + PlayerStats.baseMaxHP);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }
    }
    public void AttackRangeButtonClick()
    {
        if (Item.AccumulatedCoin > AttackRangePrice)
        {
            AttackRangepurchaseCount++;
            SavePurchaseCount();
            Debug.Log("���� ���� ���� Ƚ�� : " + YesButton.AttackRangepurchaseCount);

            PlayerStats.AttackRangeCurLevel++;
            PlayerStats.baseAttackRange = PlayerPrefs.GetFloat("AccumulatedAttackRange", AccumulatedAttackRange);
            PlayerStats.baseAttackRange += PlayerStats.AttackRangeIncrease;

            Item.AccumulatedCoin -= AttackRangePrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + AttackRangePrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");


            AccumulatedAttackRange = PlayerStats.baseAttackRange;
            PlayerPrefs.SetFloat("AccumulatedAttackRange", AccumulatedAttackRange);

            Debug.Log("���� ���� ���� : " + PlayerStats.AttackRangeCurLevel);
            Debug.Log("���� ���� : " + PlayerStats.baseAttackRange);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }
    }
    public void BulletSpeedButtonClick()
    {
        if (Item.AccumulatedCoin > BulletSpeedPrice)
        {
            BulletSpeedpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("����ü ���� Ƚ�� : " + YesButton.BulletSpeedpurchaseCount);

            PlayerStats.BulletSpeedCurLevel++;
            PlayerStats.baseBulletSpeed = PlayerPrefs.GetFloat("AccumulatedBulletSpeed", AccumulatedBulletSpeed);
            PlayerStats.baseBulletSpeed += PlayerStats.BulletSpeedIncrease;

            Item.AccumulatedCoin -= BulletSpeedPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + BulletSpeedPrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");

            AccumulatedBulletSpeed = PlayerStats.baseBulletSpeed;
            PlayerPrefs.SetFloat("AccumulatedBulletSpeed", AccumulatedBulletSpeed);

            Debug.Log("����ü �ӵ� ���� : " + PlayerStats.BulletSpeedCurLevel);
            Debug.Log("����ü �ӵ� : " + PlayerStats.baseBulletSpeed);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }
    }
    public void XPGainButtonClick()
    {
        if (Item.AccumulatedCoin > XPGainPrice)
        {
            XPGainpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("���� ���� Ƚ�� : " + YesButton.XPGainpurchaseCount);

            PlayerStats.ExperienceGainCurLevel++;
            PlayerStats.baseExperienceGain = PlayerPrefs.GetFloat("AccumulatedXPGain", AccumulatedXPGain);
            PlayerStats.baseExperienceGain += PlayerStats.ExperienceGainIncrease;

            Item.AccumulatedCoin -= XPGainPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + XPGainPrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");

            AccumulatedXPGain = PlayerStats.baseExperienceGain;
            PlayerPrefs.SetFloat("AccumulatedXPGain", AccumulatedXPGain);

            Debug.Log("���� ���� : " + PlayerStats.ExperienceGainCurLevel);
            Debug.Log("���� : " + PlayerStats.baseExperienceGain);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }
    }
    public void BulletIncreaseButtonClick()
    {
        if (Item.AccumulatedCoin > BulletIncreasePrice)
        {
            BulletIncreasepurchaseCount++;
            SavePurchaseCount();
            Debug.Log("����ü ���� Ƚ�� : " + YesButton.BulletIncreasepurchaseCount);

            PlayerStats.BulletIncreaseCurLevel++;
            PlayerStats.baseBulletCount = PlayerPrefs.GetFloat("AccumulatedBulletIncrease", AccumulatedBulletIncrease);
            PlayerStats.baseBulletCount += PlayerStats.BulletCountIncrease;

            Item.AccumulatedCoin -= BulletIncreasePrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + BulletIncreasePrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");

            AccumulatedBulletIncrease = PlayerStats.baseBulletCount;
            PlayerPrefs.SetFloat("AccumulatedBulletIncrease", AccumulatedBulletIncrease);

            Debug.Log("����ü �� ���� : " + PlayerStats.BulletIncreaseCurLevel);
            Debug.Log("����ü �� : " + PlayerStats.baseBulletCount);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }
    }
    public void HealingButtonClick()
    {
        if (Item.AccumulatedCoin > HealingPrice)
        {
            HealingpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("ȸ�� ���� Ƚ�� : " + YesButton.HealingpurchaseCount);

            PlayerStats.HealingCurLevel++;
            PlayerStats.baseHealing = PlayerPrefs.GetFloat("AccumulatedHealing", AccumulatedHealing);
            PlayerStats.baseHealing += PlayerStats.HealingIncrease;

            Item.AccumulatedCoin -= HealingPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + HealingPrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");

            AccumulatedHealing = PlayerStats.baseHealing;
            PlayerPrefs.SetFloat("AccumulatedHealing", AccumulatedHealing);

            Debug.Log("ȸ�� ���� : " + PlayerStats.HealingCurLevel);
            Debug.Log("ȸ�� : " + PlayerStats.baseHealing);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }
    }
    public void PlayerSpeedButtonClick()
    {
        if (Item.AccumulatedCoin > PlayerSpeedPrice)
        {
            PlayerSpeedpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("�̵��ӵ� ���� Ƚ�� : " + YesButton.PlayerSpeedpurchaseCount);

            PlayerStats.PlayerSpeedCurLevel++;
            PlayerStats.basePlayerSpeed = PlayerPrefs.GetFloat("AccumulatedPlayerSpeed", AccumulatedPlayerSpeed);
            PlayerStats.basePlayerSpeed += PlayerStats.PlayerSpeedIncrease;

            Item.AccumulatedCoin -= PlayerSpeedPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("�������� " + PlayerSpeedPrice + "��ŭ �����Ͽ� ���� ������ " + Item.AccumulatedCoin + "�Դϴ�.");

            AccumulatedPlayerSpeed = PlayerStats.basePlayerSpeed;
            PlayerPrefs.SetFloat("AccumulatedPlayerSpeed", AccumulatedPlayerSpeed);

            Debug.Log("�̵��ӵ� ���� : " + PlayerStats.PlayerSpeedCurLevel);
            Debug.Log("�̵��ӵ� : " + PlayerStats.basePlayerSpeed);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("������ �� �����ϴ�.");
        }

    }

}

