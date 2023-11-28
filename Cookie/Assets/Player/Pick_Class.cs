using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Class : MonoBehaviour
{
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public GameObject WinMenu;
    public GameObject Points;
    private GameObject object1;
    private float Distance1;
    private void Start() {
        object1= null;
    }
    public void picking()
    {
        object1= GameObject.FindGameObjectsWithTag("CookieMonster")[0];
        Distance1 = Vector3.Distance(object1.transform.position,this.transform.position);
        if (Distance1<=3)
        {
            this.GetComponent<MouseLook>().enabled=false;
            object1.GetComponent<AudioSource>().enabled=false;
            Time.timeScale=0f;
            WinMenu.SetActive(true);
            Points.SetActive(false);
            if (Timer.MaxTime>=40)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);
            }else if (Timer.MaxTime>20 && Timer.MaxTime<40) 
            {
                Star3.SetActive(true);
                Star2.SetActive(true);
            }else if (Timer.MaxTime<=20)
            {
                Star1.SetActive(true);
            }
        }
    }

}
