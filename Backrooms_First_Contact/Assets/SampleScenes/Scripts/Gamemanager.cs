using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    [SerializeField] GameObject enemigo;
    [SerializeField] GameObject jugador;
    [SerializeField] Transform[] puntosdesalida;

    private colision jugadorColision;
    //[SerializeField] GameObject GameOver;
   // [SerializeField] private TextMeshProUGUI textGameOver;
    private int puntoSalida;
    public static bool gameover;
    public GameObject gameoverPanel;
    // Start is called before the first frame update
    void Start()
    {
        EstablecerPunto(jugador);
        CrearNuevoSujeto();
        gameover = false;
        
        jugadorColision = jugador.GetComponent<colision>();
 
    }

    void Update()
    {
        if (jugadorColision.fueGolpeado())
        {
            gameoverPanel.SetActive(true);
            //Time.timeScale = 0;
            
        }
    }

    // Update is called once per frame
    private void EstablecerPunto(GameObject objeto)
    {
        puntoSalida = Random.Range(0, puntosdesalida.Length);
        objeto.transform.position = puntosdesalida[puntoSalida].position;
    }
    public void CrearNuevoSujeto()
    {
        Instantiate(enemigo);
        EstablecerPunto(enemigo);
    }


    public void Aparecefinal(string texto)
    {
        //GameOver.SetActive(true);
        //textGameOver.text = texto;

    }

}
