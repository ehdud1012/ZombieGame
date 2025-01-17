using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform FirePosition;
    public GameObject Bullet;
    public float BulletSpeed;
    private float AttackRange;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        AttackRange = PlayerStats.baseAttackRange;
        BulletSpeed = PlayerStats.baseBulletSpeed;
    }
    private void Shoot()
    {
        GameObject bullet = Instantiate(Bullet, FirePosition.position, FirePosition.transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        Destroy(bullet, AttackRange); // 사거리 조절

        rb.velocity = FirePosition.forward * BulletSpeed;
    }
}
