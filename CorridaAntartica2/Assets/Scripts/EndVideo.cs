using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EndVideo : MonoBehaviour
{
    public floatVariable Save;

    [HideInInspector]public enum Tipo { Cena, Painel}

    public Tipo WhatToDoOnEnd;

    public VideoPlayer VideoPlayer;
    private bool DoOnce = false;

    public int SceneToGoTo;

    public GameObject PainelToOpen;

    private void Update()
    {
        VideoPlayer.loopPointReached += BackToMainMenu;
    }
    private void BackToMainMenu(VideoPlayer vp)
    {
        if (!DoOnce)
        {

            switch (WhatToDoOnEnd)
            {
                case Tipo.Cena:
                    SceneManager.LoadScene(SceneToGoTo);
                    Save.Value = 1;
                    break;

                case Tipo.Painel:
                    PainelToOpen.SetActive(true);
                    break;
            }
            DoOnce = true;
            
        }

    }
}