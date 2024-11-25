using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float growthMultiplier = 1.5f; // Factor de crecimiento
    public float growthDuration = 5f;    // Duración del efecto
    private Vector3 originalSize;        // Tamaño original del personaje

    private void Start()
    {
        // Guarda el tamaño original del personaje
        originalSize = transform.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto tocado tiene la etiqueta "Mushroom"
        if (other.CompareTag("Mushroom"))
        {
            StartCoroutine(GrowPlayer());
            Destroy(other.gameObject); // Destruye el honguito después de usarlo
        }
    }

    private IEnumerator GrowPlayer()
    {
        // Aumenta el tamaño del personaje
        transform.localScale = originalSize * growthMultiplier;

        // Espera el tiempo especificado
        yield return new WaitForSeconds(growthDuration);

        // Vuelve al tamaño original
        transform.localScale = originalSize;
    }
}
