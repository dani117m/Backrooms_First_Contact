using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    private bool estaMuerto = false;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("obstaculo"))
        {
            estaMuerto = true;
            Debug.Log("Estoy chocando con enemigo");
        }

    }

    public bool fueGolpeado()
    {

        return estaMuerto;
    }
}
