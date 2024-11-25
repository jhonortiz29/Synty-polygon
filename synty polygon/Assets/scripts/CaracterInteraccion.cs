using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterInteraccion : MonoBehaviour
{
    private Vector3 initialPosition; // Para almacenar la posición inicial del personaje

    void Start()
    {
        // Guardar la posición inicial del personaje al inicio del juego
        initialPosition = transform.position;
    }

    void OnTriggerStay(Collider other)
    {
        // Verificar si el personaje colisiona con un objeto etiquetado como "Auto"
        if(other.CompareTag("Auto") && Input.GetKeyDown(KeyCode.E))
        {
            ResetToInitialPosition();
            Debug.Log("El personaje se subió al auto y fue reiniciado.");
        }
    }

    private void ResetToInitialPosition()
    {
        // Cambiar la posición del personaje a la posición inicial
        transform.position = initialPosition;
    }
}
