using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private string levelGameName;
    [SerializeField] private GameObject screenMainMenu;
    [SerializeField] private GameObject screenOptions;


    public void Play()
    {
        SceneManager.LoadScene(levelGameName);
    }

    public void OpenOptions()
    {
        screenMainMenu.SetActive(false);
        screenOptions.SetActive(true);
    }

    public void CloseOptions()
    {
        screenOptions.SetActive(false);
        screenMainMenu.SetActive(true);
    }

    public void Exit()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
