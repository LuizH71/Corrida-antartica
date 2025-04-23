using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject _confirmQuit;
    public floatVariable Save;

    public void ReloadScene()
    {
        Time.timeScale = 1;
        //SceneManager.UnloadScene(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void QuitConfirm(bool x)
    {
        _confirmQuit.SetActive(x);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
        Save.Value = 0;
    }
}
