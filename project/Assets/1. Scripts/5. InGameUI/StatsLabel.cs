using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsLabel : MonoBehaviour
{
    public Text DamageLabel;
    public Text GuardLabel;
    public Text MaxHPLabel;
    public Text AttackRangeLabel;
    public Text BulletSpeedLabel;
    public Text XPGainLabel;
    public Text BulletIncreaseLabel;
    public Text HealingLabel;
    public Text PlayerSpeedLabel;


    void Start()
    {
        DamageLabel = GameObject.Find("DamageLabel").GetComponent<Text>();
        GuardLabel = GameObject.Find("GuardLabel").GetComponent<Text>();
        MaxHPLabel = GameObject.Find("MaxHPLabel").GetComponent<Text>();
        AttackRangeLabel = GameObject.Find("AttackRangeLabel").GetComponent<Text>();
        BulletSpeedLabel = GameObject.Find("BulletSpeedLabel").GetComponent<Text>();
        XPGainLabel = GameObject.Find("XPGainLabel").GetComponent<Text>();
        BulletIncreaseLabel = GameObject.Find("BulletIncreaseLabel").GetComponent<Text>();
        HealingLabel = GameObject.Find("HealingLabel").GetComponent<Text>();
        PlayerSpeedLabel = GameObject.Find("PlayerSpeedLabel").GetComponent<Text>();
    }

    void Update()
    {
        DamageLabel.text =  YesButton.AccumulatedDamage.ToString() + " + " + (PlayerStats.DamageIncrease * RandomSkill.PlusDamage).ToString();
        GuardLabel.text =  YesButton.AccumulatedGuard.ToString() + " - " + (PlayerStats.GuardIncrease * RandomSkill.PlusGuard).ToString();
        MaxHPLabel.text = YesButton.AccumulatedMaxHP.ToString() + " + " + (PlayerStats.MaxHPIncrease * RandomSkill.PlusMaxHP).ToString(); 
        AttackRangeLabel.text = YesButton.AccumulatedAttackRange.ToString() + " + " + (PlayerStats.AttackRangeIncrease * RandomSkill.PlusAttackRange).ToString(); 
        BulletSpeedLabel.text = YesButton.AccumulatedBulletSpeed.ToString() + " + " + (PlayerStats.BulletSpeedIncrease * RandomSkill.PlusBulletSpeed).ToString(); 
        XPGainLabel.text = YesButton.AccumulatedXPGain.ToString() + " + " + (PlayerStats.ExperienceGainIncrease * RandomSkill.PlusXPGain).ToString(); 
        BulletIncreaseLabel.text = YesButton.AccumulatedBulletIncrease.ToString() + " + " + (PlayerStats.BulletCountIncrease * RandomSkill.PlusBulletIncrease).ToString(); 
        HealingLabel.text = YesButton.AccumulatedHealing.ToString() + " + " + (PlayerStats.HealingIncrease * RandomSkill.PlusHealing).ToString(); 
        PlayerSpeedLabel.text = YesButton.AccumulatedPlayerSpeed.ToString() + " + " + (PlayerStats.PlayerSpeedIncrease * RandomSkill.PlusPlayerSpeed).ToString(); 

    }
}
