using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Damage  데미지 증가
    public static int DamageCurLevel = 1;
    public static int DamageMaxLevel = 6;
    public static float baseDamage = 30;
    public static float DamageIncrease = 5f;
    
    // Guard  방어력 증가(적 피해량 감소)
    public static int GuardCurLevel = 1;
    public static int GuardMaxLevel = 5;
    public static float baseGuard = 10;
    public static float GuardIncrease = 1f;

    // MaxHP  최대체력
    public static int MaxHPCurLevel = 1;
    public static int MaxHPMaxLevel = 5;
    public static float baseMaxHP = 200f;
    public static float MaxHPIncrease = 5f;

    // AttackRange  공격범위
    public static int AttackRangeCurLevel = 1; 
    public static int AttackRangeMaxLevel = 5; 
    public static float baseAttackRange = 3.0f; 
    public static float AttackRangeIncrease = 0.5f; 

    // BulletSpeed  투사체 속도
    public static int BulletSpeedCurLevel = 1; 
    public static int BulletSpeedMaxLevel = 5; 
    public static float baseBulletSpeed = 10.0f; 
    public static float BulletSpeedIncrease = 1.0f; 

    // XPGain  성장 (경험치 획득량 증가)
    public static int ExperienceGainCurLevel = 1; 
    public static int ExperienceGainMaxLevel = 5; 
    public static float baseExperienceGain = 50.0f; 
    public static float ExperienceGainIncrease = 5.0f; 

    // BulletIncrease  투사체 수
    public static int BulletIncreaseCurLevel = 1; 
    public static int BulletIncreaseMaxLevel = 5; 
    public static float baseBulletCount = 1; 
    public static float BulletCountIncrease = 1; 

    // Healing  회복
    public static int HealingCurLevel = 1; 
    public static int HealingMaxLevel = 5; 
    public static float baseHealing = 0.0f; 
    public static float HealingIncrease = 1.0f; 

    // PlayerSpeed  이동속도
    public static int PlayerSpeedCurLevel = 1; 
    public static int PlayerSpeedMaxLevel = 5; 
    public static float basePlayerSpeed = 5.0f; 
    public static float PlayerSpeedIncrease = 1.0f;

}
