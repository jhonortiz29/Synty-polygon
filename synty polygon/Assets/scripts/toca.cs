using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class toca : MonoBehaviour
{
    public AudioSource quienEmite;
    public AudioClip elSonido;
    public float volumen = 1f;

   
    public static int monedasRecogidas = 0;
    public TextMeshProUGUI coinCounterText;
    public static int totalMonedas; // Total de monedas en la escena
    public GameObject gameOverText; // Referencia al texto de Game Over


    private void Start()
    {
        
        if (coinCounterText != null)
        {
            coinCounterText.text = "Monedas: " + monedasRecogidas.ToString();
        }
        // Calcula el total de monedas en la escena
        totalMonedas = GameObject.FindGameObjectsWithTag("Moneda").Length;

        if (gameOverText != null)
        {
            gameOverText.SetActive(false); // Oculta el texto al inicio
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        monedasRecogidas++;

        
        if (coinCounterText != null)
        {
            coinCounterText.text = "Monedas: " + monedasRecogidas.ToString();
        }

        AudioSource.PlayClipAtPoint(elSonido, gameObject.transform.position, volumen);
        Destroy(gameObject);

        // Comprueba si todas las monedas han sido recogidas
        if (monedasRecogidas >= totalMonedas)
        {
            if (gameOverText != null)
            {
                gameOverText.SetActive(true); // Muestra el texto de Game Over
            }
        }
    }
}


