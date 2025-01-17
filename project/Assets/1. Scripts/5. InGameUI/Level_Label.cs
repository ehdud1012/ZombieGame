using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Label : MonoBehaviour
{
    Text levelLabel;
    // Start is called before the first frame update
    void Start()
    {
        levelLabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        levelLabel.text = ("" + Player.level);
    }
}
