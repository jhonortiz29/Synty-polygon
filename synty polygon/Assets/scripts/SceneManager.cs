using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // M�todo para reiniciar el juego
    public void RestartGame()
    {
        // Reinicia las variables est�ticas de las monedas
        toca.monedasRecogidas = 0;
        toca.totalMonedas = 0;

        // Carga la escena activa actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
