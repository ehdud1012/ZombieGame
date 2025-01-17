using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    int dist = 10;
    int height = 7;
    public Transform player;
    Vector3 offset;
    void LateUpdate()
    {
        offset = player.forward * dist + Vector3.down * height;
        transform.position = Vector3.Lerp(transform.position, player.position - offset, 0.5f);
        transform.LookAt(player.transform);
        //transform.LookAt(player.transform).transform.position.nomalrized;
        //transform.position.normalized
    }
}


/*
    public class Cam : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    void Start()
    {
        offset = player.position - transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.position - offset;
        transform.LookAt(player);
    }
}
*/