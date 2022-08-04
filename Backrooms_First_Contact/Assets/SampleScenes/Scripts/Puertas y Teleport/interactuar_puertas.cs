using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactuar_puertas : MonoBehaviour
{

    public float distancia = 2f;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Raycast(OrganizationCredentials, direccion, out hit, distancia, mascara)
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia))
        {
            
            if (hit.collider.tag == "Puerta")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<abrirpuerta>().ChangeDoorState(); 
                }
            }   
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)* distancia,Color.red);
        }
    
    }
    
    


}
