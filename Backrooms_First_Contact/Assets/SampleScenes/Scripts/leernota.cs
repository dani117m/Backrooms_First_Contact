using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leernota : MonoBehaviour
{
    public GameObject notaVisual;
    private bool activa;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& activa == true)
        {
            notaVisual.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape)&& activa== true )
        {
            notaVisual.SetActive(false);         
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            activa = true;
            
        }
    }
}
