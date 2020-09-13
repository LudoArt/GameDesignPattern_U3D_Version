using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CustomEvent { OPENTITLE, CLOSETITLE }

/// <summary>
/// 被观察对象
/// </summary>
public class Subject: MonoBehaviour
{
    public static Subject Instance;

    private List<Observer> observers = new List<Observer>();

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
    }

    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public bool RemoveObserver(Observer observer)
    {
        return observers.Remove(observer);
    }

    public void Notify(CustomEvent _event)
    {
        foreach(Observer ob in observers)
        {
            ob.OnNotify(_event);
        }
    }
}
