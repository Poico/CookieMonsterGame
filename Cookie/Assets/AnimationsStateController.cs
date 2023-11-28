using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsStateController : MonoBehaviour
{
    Animator animator;
    Vector3 velocity;
    [SerializeField] GameObject Navmeshbody;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
