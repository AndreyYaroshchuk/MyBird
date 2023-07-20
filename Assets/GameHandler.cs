using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private static GameHandler instance;
    public float sflfsk;

    public static GameHandler GetInstance() { return instance; }

    private void Awake()
    {
        instance = this;
    }

    
}
