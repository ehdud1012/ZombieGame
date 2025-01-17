using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


public class Player : MonoBehaviour
{
    Rigidbody rigid;
    CapsuleCollider capsuleCollider;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        maxHealth = PlayerStats.baseMaxHP ; // baseHP를 maxHealth에 할당
        curHealth = maxHealth; // 현재 체력을 초기 최대 체력 값으로 설정
    }
    private async void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            enemy.damage = PlayerStats.baseGuard;
            curHealth -= enemy.damage;

            await Task.Delay(1000);

            Debug.Log("Player : " + curHealth);

            if(curHealth <= 0)
            {
                Pause.m_bPause = true;
                GameOver();
            }
        }
    }
    private void Update()
    {
        Recovery();
        hpbar.value = curHealth / maxHealth;
        Expbar.value = (float)curExp / maxExp;
    }
    // Hp바 구현

    public float maxHealth = 200;
    public static float curHealth = 200;
    public Slider hpbar;

    float currTime;
    void Recovery()
    {
        currTime += Time.deltaTime;
        if (currTime > 10 && curHealth < maxHealth)
        {
            curHealth += PlayerStats.baseHealing;
            currTime = 0;
        }
    }

    // 경험치 구현 / 레벨업

    public int maxExp = 100;
    public static int curExp = 0;
    public Slider Expbar;
    public static int level = 1;
    public GameObject Skill_Popup;

    public void AddExperience(int GiveXp)
    {
        curExp += GiveXp;
        if (curExp >= maxExp)
        {
            LevelUp();
            Skill_Popup.SetActive(true); 
            curExp = 0;
            Pause.m_bPause = true;
        }
    }
    public void AddExperience1(int GiveXp)
    {
        curExp += GiveXp + 50;
        if (curExp >= maxExp)
        {
            LevelUp();
            Skill_Popup.SetActive(true);
            curExp = 0;
        }
    }
    void LevelUp()
    {
        level++;
    }

    // 스킬 스킵 버튼 경험치 획득
    public void Skip()
    {
        curExp += 50;
        Debug.Log("Add Exp : " + 50);
        Debug.Log("curExp : " + curExp);
    }
    public GameObject Gameover;
    public void GameOver()
    {
        Debug.Log("게임 종료");
        Gameover.SetActive(true); // GameOver 팝업창 띄우기
    }
}
