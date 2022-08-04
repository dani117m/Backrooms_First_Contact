using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slots : MonoBehaviour
{
    public GameObject item;
    public int id;
    public string tipo;
    public string descripcion;
    public bool vacio;
    public Sprite icon; 

    public Transform slotIcon;

    private void Start()
    {
        slotIcon = transform.GetChild(0);
    }

    public void rellenarSlots()
    {
        this.GetComponent<Image>().sprite = icon;
    }
}
