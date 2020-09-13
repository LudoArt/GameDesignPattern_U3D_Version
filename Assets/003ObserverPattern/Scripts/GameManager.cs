using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GMObserver m_gMObserver;

    private void Start()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        if (m_gMObserver == null)
            m_gMObserver = new GMObserver();
        Subject.Instance.AddObserver(m_gMObserver);
    }

    public void PauseGame()
    {
        Debug.Log("Pause Game.");
        Time.timeScale = 0.0f;
    }

    public void RunningGame()
    {
        Debug.Log("Running Game.");
        Time.timeScale = 1.0f;
    }
}
