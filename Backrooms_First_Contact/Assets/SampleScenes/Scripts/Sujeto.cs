using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
public class Sujeto : MonoBehaviour
{
    private Transform objectivo;
    private NavMeshAgent agente;
    private Gamemanager gamemanager;


    
    // Start is called before the first frame update
    private void Awake() 
    {
        objectivo = GameObject.FindGameObjectWithTag("Player").transform;
        agente = GetComponent<NavMeshAgent>();
        gamemanager = FindObjectOfType<Gamemanager>();


    }

    private void Start()
    {
        StartCoroutine(tiempoDestruccion());

    }

    private void Update()
    {
        agente.SetDestination(objectivo.position);
    }
    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gamemanager.Aparecefinal("Cazado");
        }    
    }

    private IEnumerator tiempoDestruccion()
    {
        for (var i = 0; i < 15; i++)
        {
            yield return new WaitForSeconds(1);
            
        }
        gamemanager.CrearNuevoSujeto();
        Destroy(this.gameObject);
    }
}
