using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool m_bPause;

    // Start is called before the first frame update
    public static void Pause_()
    {
        if (m_bPause == false)
        {
            m_bPause = true;
        }
        else
        {
            m_bPause = false;
        }
        Debug.Log("m_bPause : " + m_bPause);
    }

    void Update()
    {
      if(m_bPause == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
