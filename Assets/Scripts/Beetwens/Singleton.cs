using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static bool isAplicationQuitting;

    private static T _instance;

    private static System.Object _lock = new System.Object();

    public static T Instance
    {
        get
        {
            if (isAplicationQuitting)
                return null;
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        var singleton = new GameObject("[SINGLETON] " + typeof(T));
                        _instance = singleton.AddComponent<T>();
                        DontDestroyOnLoad(singleton);
                    }
                }
            }

            return _instance;
        }
    }

    public virtual void OnDestroy()
    {
        isAplicationQuitting = true; 
    }
}
