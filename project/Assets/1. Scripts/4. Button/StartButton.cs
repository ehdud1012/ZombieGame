using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class StartButton: MonoBehaviour
{
    public void GameSceneChange()
    {
        SceneManager.LoadScene(1);
        Debug.Log("PlayScene Go");

        Coin.CoinCount = 0;
        Player.level = 1;
        Player.curExp = 0;
        Player.curHealth = 0;
        Enemy.EnemyDeath = 0;
        Enemy.DamageScore = 0;

        PlayerStats.baseDamage = PlayerPrefs.GetFloat("AccumulatedDamage",30f);
        PlayerStats.baseGuard = PlayerPrefs.GetFloat("AccumulatedGuard",10f);
        PlayerStats.baseMaxHP = PlayerPrefs.GetFloat("AccumulatedMaxHP", 200f);
        PlayerStats.baseAttackRange = PlayerPrefs.GetFloat("AccumulatedAttackRange",3.0f);
        PlayerStats.baseBulletSpeed = PlayerPrefs.GetFloat("AccumulatedBulletSpeed",10.0f);
        PlayerStats.baseExperienceGain = PlayerPrefs.GetFloat("AccumulatedXPGain",50.0f);
        PlayerStats.baseBulletCount = PlayerPrefs.GetFloat("AccumulatedBulletIncrease",1f);
        PlayerStats.baseHealing = PlayerPrefs.GetFloat("AccumulatedHealing",0.0f);
        PlayerStats.basePlayerSpeed = PlayerPrefs.GetFloat("AccumulatedPlayerSpeed",5.0f);
    }
}
