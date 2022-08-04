using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactuar : MonoBehaviour
{
    LayerMask mask;
    public float distancia = 1.5f;
    // Start is called before the first frame update

    public Texture2D puntero;
    public GameObject Text_interactivo;
    GameObject ultima_interaccion = null;
    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");

        Text_interactivo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Raycast(OrganizationCredentials, direccion, out hit, distancia, mascara)
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia, mask))
        {
            Deselect();
            SelectedObject(hit.transform);
            if (hit.collider.tag == "Objeto_interactivo")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Objeto_inter>().ActivarObjeto(); 
                }
            }   
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)* distancia,Color.red);
        }
        else
        {
            Deselect();
        }
    }
    
    void SelectedObject(Transform transform)
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
        ultima_interaccion = transform.gameObject;
    }

    void Deselect()
    {
        if (ultima_interaccion)
        {
            ultima_interaccion.GetComponent<Renderer>().material.color = Color.white;
            ultima_interaccion = null;
        }
    }

    void OnGUI() 
    {
        Rect rect = new Rect(Screen.width / 2, Screen.height / 2, puntero.width,puntero.height);
        GUI.DrawTexture(rect, puntero);

        if (ultima_interaccion)
        {
            Text_interactivo.SetActive(true);
        }
        else
        {
            Text_interactivo.SetActive(false);
        }
        
    }
    


}
