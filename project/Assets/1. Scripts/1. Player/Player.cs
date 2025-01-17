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

        maxHealth = PlayerStats.baseMaxHP ; // baseHP�� maxHealth�� �Ҵ�
        curHealth = maxHealth; // ���� ü���� �ʱ� �ִ� ü�� ������ ����
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
    // Hp�� ����

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

    // ����ġ ���� / ������

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

    // ��ų ��ŵ ��ư ����ġ ȹ��
    public void Skip()
    {
        curExp += 50;
        Debug.Log("Add Exp : " + 50);
        Debug.Log("curExp : " + curExp);
    }
    public GameObject Gameover;
    public void GameOver()
    {
        Debug.Log("���� ����");
        Gameover.SetActive(true); // GameOver �˾�â ����
    }
}
