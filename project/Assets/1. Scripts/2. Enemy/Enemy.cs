using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    NavMeshAgent nav;
    GameObject target;

    public float maxHealth;
    public float curHealth;
    public float damage;
    public float GiveXp;
    public static int EnemyDeath = 0;
    public static float DamageScore = 0;

    Rigidbody rigid;
    CapsuleCollider capsuleCollider;

    private void Start()
    {
        GiveXp = PlayerStats.baseExperienceGain;

        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");

        rigid = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    private void Update()
    {
        if (nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Bullet bullet = other.GetComponent<Bullet>();

            bullet.damage = PlayerStats.baseDamage;
            curHealth -= bullet.damage;
            DamageScore += bullet.damage;

            Debug.Log("Range : " + curHealth);

            if (curHealth <= 0)
            {
                Destroy(gameObject);

                EnemyDeath++;

                Player player = FindObjectOfType<Player>();
                if (player != null)
                {
                    player.AddExperience((int)GiveXp);
                }
            }
        }
    }
}