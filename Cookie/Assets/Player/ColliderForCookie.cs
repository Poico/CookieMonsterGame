using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderForCookie : MonoBehaviour
{
    [SerializeField] Text text;
    int NCookies=0;
    
    AudioSource audio_;
    private void Start() {
        audio_ = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other) {        
        if (other.tag=="Cookie")
        {
            audio_.Play();
            Destroy(other.gameObject);
            NCookies+=1;
            text.text=NCookies+"";
        }
    }
}
