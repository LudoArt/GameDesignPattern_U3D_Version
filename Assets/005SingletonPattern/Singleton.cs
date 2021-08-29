using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// T约束必须为Singleton<T>类型
// 如想创建一个GameManager单例：public class GameManager : Singleton<GameManager>
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    // 定义为protected类型方便子类获取和修改
    protected static T _Instance = null;
    public static T Instance()
    {
        return _Instance;
    }

    protected void Awake()
    {
        if (_Instance == null)
        {
            _Instance = (T)this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}