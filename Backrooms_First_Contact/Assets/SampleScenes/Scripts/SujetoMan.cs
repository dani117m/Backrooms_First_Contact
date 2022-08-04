using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SujetoMan : MonoBehaviour
{
    // Start is called before the first frame update
  private Transform objetivo;
  private NavMeshAgent agente;

  private void Awake()
  {
    objetivo = GameObject.FindGameObjectWithTag("Player").transform;
    agente = GetComponent<NavMeshAgent>();
  }

  private void Update()
  {
    agente.SetDestination(objetivo.position);
  }
}
