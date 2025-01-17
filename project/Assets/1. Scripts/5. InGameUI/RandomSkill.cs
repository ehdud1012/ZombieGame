using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSkill : MonoBehaviour
{
    // 활성화,비활성화 할 오브젝트


    public GameObject Skill; // 뽑는 창

    // 불러올 이미지 오브젝트

    public Image DrawImage1;// 랜덤 이미지를 출력할 오브젝트
    public Image DrawImage2;
    public Image DrawImage3;

    //숫자 이미지
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    public Sprite Image7;
    public Sprite Image8;
    public Sprite Image9;
    public Sprite Image10;
    public Sprite Image11;

    // 변수
    private int RandomInt; // 랜덤 변수

    public Button Change1;
    public Button Change2;
    public Button Change3;

    public Button Choice1;
    public Button Choice2;
    public Button Choice3;

    private int MaxDrawCount = 2; // 최대 뽑기 횟수 설정

    private int CurDraw1Count = 0;
    private int CurDraw2Count = 0;
    private int CurDraw3Count = 0;
    public void OneDraw() // 1회 뽑기 버튼을 클릭 시
    {
        if (CurDraw1Count < MaxDrawCount)
        {
            RandomInt = Random.Range(1, 12);
            Choice1.interactable = true;
            switch (RandomInt)
            {
                case 1:
                    DrawImage1.sprite = Image1;
                    break;
                case 2:
                    DrawImage1.sprite = Image2;
                    break;
                case 3:
                    DrawImage1.sprite = Image3;
                    break;
                case 4:
                    DrawImage1.sprite = Image4;
                    break;
                case 5:
                    DrawImage1.sprite = Image5;
                    break;
                case 6:
                    DrawImage1.sprite = Image6;
                    break;
                case 7:
                    DrawImage1.sprite = Image7;
                    break;
                case 8:
                    DrawImage1.sprite = Image8;
                    break;
                case 9:
                    DrawImage1.sprite = Image9;
                    break;
                case 10:
                    DrawImage1.sprite = Image10;
                    break;
                case 11:
                    DrawImage1.sprite = Image11;
                    break;

            }
            CurDraw1Count++;
        }
        else
        {
            Change1.interactable = false;
        }
    }
    public void twoDraw()
    {
        if (CurDraw2Count < MaxDrawCount)
        {
            RandomInt = Random.Range(1, 12);
            Choice2.interactable = true;

            switch (RandomInt)
            {
                case 1:
                    DrawImage2.sprite = Image1;
                    break;
                case 2:
                    DrawImage2.sprite = Image2;
                    break;
                case 3:
                    DrawImage2.sprite = Image3;
                    break;
                case 4:
                    DrawImage2.sprite = Image4;
                    break;
                case 5:
                    DrawImage2.sprite = Image5;
                    break;
                case 6:
                    DrawImage2.sprite = Image6;
                    break;
                case 7:
                    DrawImage2.sprite = Image7;
                    break;
                case 8:
                    DrawImage2.sprite = Image8;
                    break;
                case 9:
                    DrawImage2.sprite = Image9;
                    break;
                case 10:
                    DrawImage2.sprite = Image10;
                    break;
                case 11:
                    DrawImage2.sprite = Image11;
                    break;

            }
            CurDraw2Count++;
        }
        else
        {
            Change2.interactable = false;
        }


    }
    public void ThreeDraw() // 1회 뽑기 버튼을 클릭 시
    {
        if (CurDraw3Count < MaxDrawCount)
        {
            RandomInt = Random.Range(1, 12);
            Choice3.interactable = true;
            switch (RandomInt)
            {
                case 1:
                    DrawImage3.sprite = Image1;
                    break;
                case 2:
                    DrawImage3.sprite = Image2;
                    break;
                case 3:
                    DrawImage3.sprite = Image3;
                    break;
                case 4:
                    DrawImage3.sprite = Image4;
                    break;
                case 5:
                    DrawImage3.sprite = Image5;
                    break;
                case 6:
                    DrawImage3.sprite = Image6;
                    break;
                case 7:
                    DrawImage3.sprite = Image7;
                    break;
                case 8:
                    DrawImage3.sprite = Image8;
                    break;
                case 9:
                    DrawImage3.sprite = Image9;
                    break;
                case 10:
                    DrawImage3.sprite = Image10;
                    break;
                case 11:
                    DrawImage3.sprite = Image11;
                    break;

            }
            CurDraw3Count++;
        }
        else
        {
            Change3.interactable = false;
        }

    }
    public static float PlusDamage = 0;
    public static float PlusGuard;
    public static float PlusMaxHP;
    public static float PlusAttackRange;
    public static float PlusBulletSpeed;
    public static float PlusXPGain;
    public static float PlusBulletIncrease;
    public static float PlusHealing;
    public static float PlusPlayerSpeed;

    public void Skillchoice1()
    {
        if (Choice1.GetComponent<Image>().sprite == null)
        {
            Choice1.interactable = false;
            return;
        }

        if (Choice1.GetComponent<Image>().sprite == Image1)
        {
            PlusDamage++;
            PlayerStats.baseDamage += PlayerStats.DamageIncrease * PlusDamage;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image2)
        {
            PlusGuard++;
            PlayerStats.baseGuard += PlayerStats.GuardIncrease * PlusGuard;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image3)
        {
            PlusMaxHP++;
            PlayerStats.baseMaxHP += PlayerStats.MaxHPIncrease * PlusMaxHP;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image4)
        {
            PlusAttackRange++;
            PlayerStats.baseAttackRange += PlayerStats.AttackRangeIncrease * PlusAttackRange;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image5)
        {
            PlusBulletSpeed++;
            PlayerStats.baseBulletSpeed += PlayerStats.BulletSpeedIncrease * PlusBulletSpeed;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image6)
        {
            PlusXPGain++;
            PlayerStats.baseExperienceGain += PlayerStats.ExperienceGainIncrease * PlusXPGain;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image7)
        {
            PlusBulletIncrease++;
            PlayerStats.baseBulletCount += PlayerStats.BulletCountIncrease * PlusBulletIncrease;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image8)
        {
            PlusHealing++;
            PlayerStats.baseHealing += PlayerStats.HealingIncrease * PlusHealing;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image9)
        {
            PlusPlayerSpeed++;
            PlayerStats.basePlayerSpeed += PlayerStats.PlayerSpeedIncrease * PlusPlayerSpeed;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image10)
        {
            Item.count = 10;
            Coin.CoinCount += Item.count;
        }
        else if (Choice1.GetComponent<Image>().sprite == Image11)
        {
            Player.curHealth = 200;
        }

        Invoke("CloseDraw", 0.2f);
    }
    public void Skillchoice2()
    {
        if (Choice2.GetComponent<Image>().sprite == null)
        {
            Choice2.interactable = false;
            return;
        }

        if (Choice2.GetComponent<Image>().sprite == null)
        {
            Choice2.interactable = false;
        }

        if (Choice2.GetComponent<Image>().sprite == Image1)
        {
            PlusDamage++;
            PlayerStats.baseDamage += PlayerStats.DamageIncrease * PlusDamage;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image2)
        {
            PlusGuard++;
            PlayerStats.baseGuard += PlayerStats.GuardIncrease * PlusGuard;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image3)
        {
            PlusMaxHP++;
            PlayerStats.baseMaxHP += PlayerStats.MaxHPIncrease * PlusMaxHP;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image4)
        {
            PlusAttackRange++;
            PlayerStats.baseAttackRange += PlayerStats.AttackRangeIncrease * PlusAttackRange;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image5)
        {
            PlusBulletSpeed++;
            PlayerStats.baseBulletSpeed += PlayerStats.BulletSpeedIncrease * PlusBulletSpeed;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image6)
        {
            PlusXPGain++;
            PlayerStats.baseExperienceGain += PlayerStats.ExperienceGainIncrease * PlusXPGain;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image7)
        {
            PlusBulletIncrease++;
            PlayerStats.baseBulletCount += PlayerStats.BulletCountIncrease * PlusBulletIncrease;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image8)
        {
            PlusHealing++;
            PlayerStats.baseHealing += PlayerStats.HealingIncrease * PlusHealing;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image9)
        {
            PlusPlayerSpeed++;
            PlayerStats.basePlayerSpeed += PlayerStats.PlayerSpeedIncrease * PlusPlayerSpeed;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image10)
        {
            Item.count = 10;
            Coin.CoinCount += Item.count;
        }
        else if (Choice2.GetComponent<Image>().sprite == Image11)
        {
            Player.curHealth = 200;
        }
        Invoke("CloseDraw", 0.2f);
    }
    public void Skillchoice3()
    {
        if (Choice3.GetComponent<Image>().sprite == null)
        {
            Choice3.interactable = false;
            return;
        }

        if (Choice3.GetComponent<Image>().sprite == Image1)
        {
            PlusDamage++;
            PlayerStats.baseDamage += PlayerStats.DamageIncrease * PlusDamage;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image2)
        {
            PlusGuard++;
            PlayerStats.baseGuard += PlayerStats.GuardIncrease * PlusGuard;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image3)
        {
            PlusMaxHP++;
            PlayerStats.baseMaxHP += PlayerStats.MaxHPIncrease * PlusMaxHP;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image4)
        {
            PlusAttackRange++;
            PlayerStats.baseAttackRange += PlayerStats.AttackRangeIncrease * PlusAttackRange;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image5)
        {
            PlusBulletSpeed++;
            PlayerStats.baseBulletSpeed += PlayerStats.BulletSpeedIncrease * PlusBulletSpeed;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image6)
        {
            PlusXPGain++;
            PlayerStats.baseExperienceGain += PlayerStats.ExperienceGainIncrease * PlusXPGain;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image7)
        {
            PlusBulletIncrease++;
            PlayerStats.baseBulletCount += PlayerStats.BulletCountIncrease * PlusBulletIncrease;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image8)
        {
            PlusHealing++;
            PlayerStats.baseHealing += PlayerStats.HealingIncrease * PlusHealing;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image9)
        {
            PlusPlayerSpeed++;
            PlayerStats.basePlayerSpeed += PlayerStats.PlayerSpeedIncrease * PlusPlayerSpeed;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image10)
        {
            Item.count = 10;
            Coin.CoinCount += Item.count;
        }
        else if (Choice3.GetComponent<Image>().sprite == Image11)
        {
            Player.curHealth = 200;
        }

        Invoke("CloseDraw", 0.2f);
    }
    public void CloseDraw()
    {
        Change1.interactable = true;
        Change2.interactable = true;
        Change3.interactable = true;

        DrawImage1.sprite = null;
        DrawImage2.sprite = null;
        DrawImage3.sprite = null;

        CurDraw1Count = 0;
        CurDraw2Count = 0;
        CurDraw3Count = 0;

        Skill.SetActive(false);
    }
}