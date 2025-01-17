using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToGameOver : MonoBehaviour
{
    public GameObject BackToMain; 
    public void NoClick()
    {
        BackToMain.SetActive(false);
    }
}
