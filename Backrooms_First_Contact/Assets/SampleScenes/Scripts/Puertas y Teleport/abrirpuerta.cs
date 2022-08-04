using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirpuerta : MonoBehaviour
{
    public bool puertaAbierta = false;
    public float puertaOpenA = 95.0f;
    public float puertaCloseB = 0.0f;
    public float smooth = 3.0f;
    public void ChangeDoorState()
    {
        puertaAbierta = !puertaAbierta;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puertaAbierta)
        {
            
            Quaternion targetRotacion = Quaternion.Euler(-90, puertaOpenA, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotacion, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotacion2 = Quaternion.Euler(-90, puertaCloseB, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotacion2, smooth * Time.deltaTime);
            
        }
        
    }
}
