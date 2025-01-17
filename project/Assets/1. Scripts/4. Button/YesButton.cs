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
            Debug.Log("데미지 구매 횟수 : " + YesButton.DamagepurchaseCount);
            PlayerStats.DamageCurLevel++;

            PlayerStats.baseDamage = PlayerPrefs.GetFloat("AccumulatedDamage", AccumulatedDamage);
            PlayerStats.baseDamage += PlayerStats.DamageIncrease;

            Item.AccumulatedCoin -= DamagePrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + DamagePrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");

            AccumulatedDamage = PlayerStats.baseDamage; // 누적 데미지를 현재 데미지로 업데이트
            PlayerPrefs.SetFloat("AccumulatedDamage", AccumulatedDamage);

            Debug.Log("데미지 레벨 : " + PlayerStats.DamageCurLevel);
            Debug.Log("총알 피해량 : " + PlayerStats.baseDamage);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }
    }

    public void GuardButtonClick()
    {
        if (Item.AccumulatedCoin > GuardPrice)
        {
            GuardpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("가드 구매 횟수 : " + YesButton.GuardpurchaseCount);

            PlayerStats.GuardCurLevel++;
            PlayerStats.baseGuard = PlayerPrefs.GetFloat("AccumulatedGuard", AccumulatedGuard);
            PlayerStats.baseGuard -= PlayerStats.GuardIncrease;

            Item.AccumulatedCoin -= GuardPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + GuardPrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");


            AccumulatedGuard = PlayerStats.baseGuard;
            PlayerPrefs.SetFloat("AccumulatedGuard", AccumulatedGuard);

            Debug.Log("가드 레벨 : " + PlayerStats.GuardCurLevel);
            Debug.Log("적 피해량 : " + PlayerStats.baseGuard);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");

        }
    }
    public void MaxHPButtonClick()
    {
        if (Item.AccumulatedCoin > MaxHPPrice)
        {
            MaxHPpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("HP 구매 횟수 : " + YesButton.MaxHPpurchaseCount);

            PlayerStats.MaxHPCurLevel++;
            PlayerStats.baseMaxHP = PlayerPrefs.GetFloat("AccumulatedMaxHP", AccumulatedMaxHP);
            PlayerStats.baseMaxHP += PlayerStats.MaxHPIncrease;

            Item.AccumulatedCoin -= MaxHPPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + MaxHPPrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");

            AccumulatedMaxHP = PlayerStats.baseMaxHP;
            PlayerPrefs.SetFloat("AccumulatedMaxHP", AccumulatedMaxHP);

            Debug.Log("최대체력 레벨 : " + PlayerStats.MaxHPCurLevel);
            Debug.Log("최대 체력 : " + PlayerStats.baseMaxHP);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }
    }
    public void AttackRangeButtonClick()
    {
        if (Item.AccumulatedCoin > AttackRangePrice)
        {
            AttackRangepurchaseCount++;
            SavePurchaseCount();
            Debug.Log("공격 범위 구매 횟수 : " + YesButton.AttackRangepurchaseCount);

            PlayerStats.AttackRangeCurLevel++;
            PlayerStats.baseAttackRange = PlayerPrefs.GetFloat("AccumulatedAttackRange", AccumulatedAttackRange);
            PlayerStats.baseAttackRange += PlayerStats.AttackRangeIncrease;

            Item.AccumulatedCoin -= AttackRangePrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + AttackRangePrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");


            AccumulatedAttackRange = PlayerStats.baseAttackRange;
            PlayerPrefs.SetFloat("AccumulatedAttackRange", AccumulatedAttackRange);

            Debug.Log("공격 범위 레벨 : " + PlayerStats.AttackRangeCurLevel);
            Debug.Log("공격 범위 : " + PlayerStats.baseAttackRange);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }
    }
    public void BulletSpeedButtonClick()
    {
        if (Item.AccumulatedCoin > BulletSpeedPrice)
        {
            BulletSpeedpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("투사체 구매 횟수 : " + YesButton.BulletSpeedpurchaseCount);

            PlayerStats.BulletSpeedCurLevel++;
            PlayerStats.baseBulletSpeed = PlayerPrefs.GetFloat("AccumulatedBulletSpeed", AccumulatedBulletSpeed);
            PlayerStats.baseBulletSpeed += PlayerStats.BulletSpeedIncrease;

            Item.AccumulatedCoin -= BulletSpeedPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + BulletSpeedPrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");

            AccumulatedBulletSpeed = PlayerStats.baseBulletSpeed;
            PlayerPrefs.SetFloat("AccumulatedBulletSpeed", AccumulatedBulletSpeed);

            Debug.Log("투사체 속도 레벨 : " + PlayerStats.BulletSpeedCurLevel);
            Debug.Log("투사체 속도 : " + PlayerStats.baseBulletSpeed);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }
    }
    public void XPGainButtonClick()
    {
        if (Item.AccumulatedCoin > XPGainPrice)
        {
            XPGainpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("성장 구매 횟수 : " + YesButton.XPGainpurchaseCount);

            PlayerStats.ExperienceGainCurLevel++;
            PlayerStats.baseExperienceGain = PlayerPrefs.GetFloat("AccumulatedXPGain", AccumulatedXPGain);
            PlayerStats.baseExperienceGain += PlayerStats.ExperienceGainIncrease;

            Item.AccumulatedCoin -= XPGainPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + XPGainPrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");

            AccumulatedXPGain = PlayerStats.baseExperienceGain;
            PlayerPrefs.SetFloat("AccumulatedXPGain", AccumulatedXPGain);

            Debug.Log("성장 레벨 : " + PlayerStats.ExperienceGainCurLevel);
            Debug.Log("성장 : " + PlayerStats.baseExperienceGain);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }
    }
    public void BulletIncreaseButtonClick()
    {
        if (Item.AccumulatedCoin > BulletIncreasePrice)
        {
            BulletIncreasepurchaseCount++;
            SavePurchaseCount();
            Debug.Log("투사체 구매 횟수 : " + YesButton.BulletIncreasepurchaseCount);

            PlayerStats.BulletIncreaseCurLevel++;
            PlayerStats.baseBulletCount = PlayerPrefs.GetFloat("AccumulatedBulletIncrease", AccumulatedBulletIncrease);
            PlayerStats.baseBulletCount += PlayerStats.BulletCountIncrease;

            Item.AccumulatedCoin -= BulletIncreasePrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + BulletIncreasePrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");

            AccumulatedBulletIncrease = PlayerStats.baseBulletCount;
            PlayerPrefs.SetFloat("AccumulatedBulletIncrease", AccumulatedBulletIncrease);

            Debug.Log("투사체 수 레벨 : " + PlayerStats.BulletIncreaseCurLevel);
            Debug.Log("투사체 수 : " + PlayerStats.baseBulletCount);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }
    }
    public void HealingButtonClick()
    {
        if (Item.AccumulatedCoin > HealingPrice)
        {
            HealingpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("회복 구매 횟수 : " + YesButton.HealingpurchaseCount);

            PlayerStats.HealingCurLevel++;
            PlayerStats.baseHealing = PlayerPrefs.GetFloat("AccumulatedHealing", AccumulatedHealing);
            PlayerStats.baseHealing += PlayerStats.HealingIncrease;

            Item.AccumulatedCoin -= HealingPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + HealingPrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");

            AccumulatedHealing = PlayerStats.baseHealing;
            PlayerPrefs.SetFloat("AccumulatedHealing", AccumulatedHealing);

            Debug.Log("회복 레벨 : " + PlayerStats.HealingCurLevel);
            Debug.Log("회복 : " + PlayerStats.baseHealing);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }
    }
    public void PlayerSpeedButtonClick()
    {
        if (Item.AccumulatedCoin > PlayerSpeedPrice)
        {
            PlayerSpeedpurchaseCount++;
            SavePurchaseCount();
            Debug.Log("이동속도 구매 횟수 : " + YesButton.PlayerSpeedpurchaseCount);

            PlayerStats.PlayerSpeedCurLevel++;
            PlayerStats.basePlayerSpeed = PlayerPrefs.GetFloat("AccumulatedPlayerSpeed", AccumulatedPlayerSpeed);
            PlayerStats.basePlayerSpeed += PlayerStats.PlayerSpeedIncrease;

            Item.AccumulatedCoin -= PlayerSpeedPrice;
            PlayerPrefs.SetInt("AccumulatedCoin", Item.AccumulatedCoin);
            Debug.Log("상점에서 " + PlayerSpeedPrice + "만큼 구매하여 남은 코인은 " + Item.AccumulatedCoin + "입니다.");

            AccumulatedPlayerSpeed = PlayerStats.basePlayerSpeed;
            PlayerPrefs.SetFloat("AccumulatedPlayerSpeed", AccumulatedPlayerSpeed);

            Debug.Log("이동속도 레벨 : " + PlayerStats.PlayerSpeedCurLevel);
            Debug.Log("이동속도 : " + PlayerStats.basePlayerSpeed);
        }
        else
        {
            NoPurchase.SetActive(true);
            Debug.Log("구매할 수 없습니다.");
        }

    }

}

