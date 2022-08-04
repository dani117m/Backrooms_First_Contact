using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpPuertas : MonoBehaviour
{
    public Transform Target;
    public GameObject jugador;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        jugador.transform.position = Target.transform.position;
    }
}
