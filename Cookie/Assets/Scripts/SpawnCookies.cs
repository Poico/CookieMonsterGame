using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnCookies : MonoBehaviour
{
    bool var=true;
    [SerializeField] GameObject CookieMan;
    [SerializeField] Transform SpawnLocation;
    void Update()
    {
        
        try
        {
            GameObject[] cookies=GameObject.FindGameObjectsWithTag("Cookie");
            if (cookies[0]==null)
            {
                
            }
        }
        catch (System.Exception)
        {            
            if (var)
            {
                Instantiate(CookieMan, SpawnLocation.transform.position,Quaternion.Euler(0,0,0));
                var=false;
            }
            
        }
    }
}
