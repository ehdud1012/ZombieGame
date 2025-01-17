using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeathLabel : MonoBehaviour
{
    Text enemyDeathLabel;
    // Start is called before the first frame update
    void Start()
    {
        enemyDeathLabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyDeathLabel.text = ("" + Enemy.EnemyDeath);
    }
}
