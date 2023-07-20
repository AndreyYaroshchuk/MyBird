using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HUD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private NextLevel nextLevel;
    [SerializeField] private GameObject menu;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject optionMenu;
    [SerializeField] private GameObject play;
    [SerializeField] private GameObject restart;
    [SerializeField] private GameObject option;
    [SerializeField] private GameObject exit;

    [SerializeField] private GameObject restartGameOver;
    [SerializeField] private GameObject optionGameOver;
    [SerializeField] private GameObject exitGameOver;

    private void Update()
    {
        Score();
    }
    public void ButtonMenu()
    {
        GameController.Instance.GameStay = GameStay.Pause;
        menu.SetActive(true);

    }
    public void ButtonPlay()
    {
        menu.SetActive(false);
        GameController.Instance.GameStay = GameStay.Play;

    }
    public void ButtonRestrat()
    {
        GameController.Instance.GameStay = GameStay.Play;
        SceneManager.LoadScene(1, LoadSceneMode.Single); 

    }
    public void ButtonOptions()
    {
        play.SetActive(false);
        restart.SetActive(false);
        option.SetActive(false);
        exit.SetActive(false);
        optionMenu.SetActive(true);
        restartGameOver.SetActive(false);
        optionGameOver.SetActive(false);
        exitGameOver.SetActive(false);
    }
    
    public void ButtonMuteMusic()
    {
        audioSource.mute = true;
    }
    public void ButtonPlayMusic()
    {
        audioSource.mute = false;
    }
    public void ButtonCloseOptionMenu()
    {
        play.SetActive(true);
        restart.SetActive(true);
        option.SetActive(true);
        exit.SetActive(true);
        optionMenu.SetActive(false);
        restartGameOver.SetActive(true);
        optionGameOver.SetActive(true);
        exitGameOver.SetActive(true);
    }
    public void ButtonExit()
    {
        Application.Quit();
    }
    private void Score()
    {
        score.text = nextLevel.Score.ToString();
        
    }

}
