using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class MainMenu : MonoBehaviour
{
    public floatVariable Save;

    public GameObject Logos;
    public PlayableDirector Director;
    private void Start()
    {
        if(Save.Value == 1)
        {
            Logos.SetActive(false);
            Director.enabled = false;
        }
    }
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
