using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogfollower : MonoBehaviour
{


    public Transform target; // El personaje a seguir
    public float speed = 5f; // Velocidad del perrito
    public float stoppingDistance = 2f; // Distancia mínima para detenerse

    void Update()
    {
        // Calcula la distancia entre el perrito y el objetivo
        float distance = Vector3.Distance(transform.position, target.position);

        // Si está fuera del rango de la distancia mínima, moverse hacia el personaje
        if (distance > stoppingDistance)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            // Opcional: Gira el perrito hacia el personaje
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }
}
