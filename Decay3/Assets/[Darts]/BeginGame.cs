using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    public GameObject BeginScreen;
    public GameObject Audio;
    public GameObject HealthBarSetUp;
    public GameObject EXPBarSetUp;
    void Start()
    {
        Time.timeScale = 0;
        BeginScreen.SetActive(true);
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        BeginScreen.SetActive(false);
        Audio.SetActive(true);
        HealthBarSetUp.SetActive(true);
        EXPBarSetUp.SetActive(true);
    }
    public void Options()
    {

    }
    public void Credits()
    {

    }
    public void QuitGame()
    {

    }
}
