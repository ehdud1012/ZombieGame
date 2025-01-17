using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class ShopButton : MonoBehaviour
{
    public void GameSceneChange()
    {
        SceneManager.LoadScene(2);
        Debug.Log("ShopScene Go");
    }
}
