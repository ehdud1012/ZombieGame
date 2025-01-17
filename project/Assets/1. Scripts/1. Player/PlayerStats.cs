using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Damage  ������ ����
    public static int DamageCurLevel = 1;
    public static int DamageMaxLevel = 6;
    public static float baseDamage = 30;
    public static float DamageIncrease = 5f;
    
    // Guard  ���� ����(�� ���ط� ����)
    public static int GuardCurLevel = 1;
    public static int GuardMaxLevel = 5;
    public static float baseGuard = 10;
    public static float GuardIncrease = 1f;

    // MaxHP  �ִ�ü��
    public static int MaxHPCurLevel = 1;
    public static int MaxHPMaxLevel = 5;
    public static float baseMaxHP = 200f;
    public static float MaxHPIncrease = 5f;

    // AttackRange  ���ݹ���
    public static int AttackRangeCurLevel = 1; 
    public static int AttackRangeMaxLevel = 5; 
    public static float baseAttackRange = 3.0f; 
    public static float AttackRangeIncrease = 0.5f; 

    // BulletSpeed  ����ü �ӵ�
    public static int BulletSpeedCurLevel = 1; 
    public static int BulletSpeedMaxLevel = 5; 
    public static float baseBulletSpeed = 10.0f; 
    public static float BulletSpeedIncrease = 1.0f; 

    // XPGain  ���� (����ġ ȹ�淮 ����)
    public static int ExperienceGainCurLevel = 1; 
    public static int ExperienceGainMaxLevel = 5; 
    public static float baseExperienceGain = 50.0f; 
    public static float ExperienceGainIncrease = 5.0f; 

    // BulletIncrease  ����ü ��
    public static int BulletIncreaseCurLevel = 1; 
    public static int BulletIncreaseMaxLevel = 5; 
    public static float baseBulletCount = 1; 
    public static float BulletCountIncrease = 1; 

    // Healing  ȸ��
    public static int HealingCurLevel = 1; 
    public static int HealingMaxLevel = 5; 
    public static float baseHealing = 0.0f; 
    public static float HealingIncrease = 1.0f; 

    // PlayerSpeed  �̵��ӵ�
    public static int PlayerSpeedCurLevel = 1; 
    public static int PlayerSpeedMaxLevel = 5; 
    public static float basePlayerSpeed = 5.0f; 
    public static float PlayerSpeedIncrease = 1.0f;

}
