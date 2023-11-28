using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Run : MonoBehaviour
{
    Animator animator;
    private NavMeshAgent _agent;
    GameObject Player;

    public float EnemyDistanceRun=6f;
    private void Start() {
        Player=GameObject.FindGameObjectsWithTag("Player")[0];
        animator= GetComponent<Animator>();
       _agent = GetComponent<NavMeshAgent>();
    }
    void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        if (distance<EnemyDistanceRun)
        {            
            Vector3 dirToPlayer = transform.position- Player.transform.position;
            Vector3 newPos= transform.position+ dirToPlayer;
            _agent.SetDestination(newPos);
        }
        animator.SetFloat("velocidade",_agent.velocity.magnitude);
    }
    
}
