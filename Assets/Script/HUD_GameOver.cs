using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUD_GameOver : MonoBehaviour
{
    [SerializeField] private GameObject restart;
    [SerializeField] private GameObject option;
    [SerializeField] private GameObject exit;
    [SerializeField] private GameObject optionMenu;
    [SerializeField] private AudioSource audioSource;
    public void ButtonRestrat()
    {
        GameController.Instance.GameStay = GameStay.Play;
        SceneManager.LoadScene(1, LoadSceneMode.Single);

    }
    public void ButtonOptions()
    {
        restart.SetActive(false);
        option.SetActive(false);
        exit.SetActive(false);
        optionMenu.SetActive(true);
        
    }
    public void ButtonMuteMusic()
    {
        audioSource.mute = true;    
    }
    public void ButtonPlayMusic() { 
        audioSource.mute = false;
    }
    public void ButtonCloseOptionMenu()
    {
        restart.SetActive(true);
        option.SetActive(true);
        exit.SetActive(true);
        optionMenu.SetActive(false);
    }
    public void ButtonExit()
    {
        Application.Quit();
    }
}
