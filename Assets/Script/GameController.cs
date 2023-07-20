using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStay { Play, Pause }
public class GameController : MonoBehaviour
{

    private GameStay gameStay;
    static private GameController instance;

    public GameStay GameStay
    {
        get => gameStay;


        set
        {
            if (value == GameStay.Play)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;
            }
            gameStay = value;
        }
    }

    public static GameController Instance { get { return instance; } }

    private void Awake()
    {
        instance = this;
    }
}
