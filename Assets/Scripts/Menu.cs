using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Scene_1()
    {
        SceneManager.LoadScene("belajar-AngryBirds");
    }

    public void Scene_2()
    {
        SceneManager.LoadScene("belajar-AngryBirds 1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
