using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
 
   public void GameSceneStart()
    {
        SceneManager.LoadScene("GameScene");

    }
    public void quýt()
    {
        Application.Quit();
    }

    public void restart()
    {
        SceneManager.LoadScene("GameScene");

    }
}
