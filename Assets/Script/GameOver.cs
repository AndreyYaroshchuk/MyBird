using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Birds newBirds = collision.gameObject.GetComponent<Birds>();        
        if(newBirds != null)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }
}
