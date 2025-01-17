using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class BackButton : MonoBehaviour
{
    public void GameSceneChange()
    {
        SceneManager.LoadScene(0);
        Debug.Log("MainScene Go");
    }
}
