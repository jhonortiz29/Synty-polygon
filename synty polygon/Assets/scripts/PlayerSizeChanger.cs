using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float growthMultiplier = 1.5f; // Factor de crecimiento
    public float growthDuration = 5f;    // Duraci�n del efecto
    private Vector3 originalSize;        // Tama�o original del personaje

    private void Start()
    {
        // Guarda el tama�o original del personaje
        originalSize = transform.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto tocado tiene la etiqueta "Mushroom"
        if (other.CompareTag("Mushroom"))
        {
            StartCoroutine(GrowPlayer());
            Destroy(other.gameObject); // Destruye el honguito despu�s de usarlo
        }
    }

    private IEnumerator GrowPlayer()
    {
        // Aumenta el tama�o del personaje
        transform.localScale = originalSize * growthMultiplier;

        // Espera el tiempo especificado
        yield return new WaitForSeconds(growthDuration);

        // Vuelve al tama�o original
        transform.localScale = originalSize;
    }
}
