using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menuinicial : MonoBehaviour
{
    // Start is called before the first frame update
    private void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}   
