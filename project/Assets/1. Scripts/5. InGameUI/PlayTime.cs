using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    public GameObject Middleboss;
    public GameObject Boss;
    public Transform player;
    public GameObject Gameover;

    float _Sec;
    int _Min;

    [SerializeField] Text _TimerText;

    private void Start()
    {
        Invoke("MonsterSpawn", 20.0f);
        Invoke("MonsterSpawn2", 40.0f);
    }
    void Update()
    {
        Timer();
    }
    private void Timer()
    {
        _Sec += Time.deltaTime;

        _TimerText.text = string.Format("{0:D2}:{1:D2}", _Min, (int)_Sec);

        if ((int)_Sec > 59)
        {
            _Sec = 0;
            _Min++;
        }
        Invoke("GameOver", 60.0f);
    }

    public void GameOver()
    {
        Gameover.SetActive(true);
        Pause.Pause_();
    }

    // 중간보스 스폰 스크립트
    private void MonsterSpawn()
    {
        Instantiate(Middleboss, new Vector3(-50, 0, 13), Quaternion.identity);
        Instantiate(Middleboss, new Vector3(-1, 0, 42), Quaternion.identity);
    }
    private void MonsterSpawn2()
    {
        Instantiate(Boss, new Vector3(-50, 0, 13), Quaternion.identity);
    }
}
