using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject PointsBox;
    [SerializeField] GameObject LostMenu;
    Text text;
    public static float MaxTime=60;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MaxTime-=Time.deltaTime;
        text.text = Mathf.Round(MaxTime).ToString();
        if (Mathf.Round(MaxTime)<=0)
        {
            PointsBox.SetActive(false);            
            LostMenu.SetActive(true);
            timeScale();
        }        
    }
    void timeScale()
    {
        Time.timeScale=0f;
    }
}
