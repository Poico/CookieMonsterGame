using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
     public static bool Paused=false;
     [SerializeField] GameObject PausedMenuUI;

    public bool MenuPause()
    {
        if (Paused)
        {
            Resuming();
            return Paused;
        }else{
            Pausing();
            return Paused;
        }
    }
    void Resuming()
    {
        PausedMenuUI.SetActive(false);
        Time.timeScale=1f;
        Paused=false;
    }

    void Pausing()
    {
        PausedMenuUI.SetActive(true);
        Time.timeScale=0f;
        Paused=true;
    }

}
