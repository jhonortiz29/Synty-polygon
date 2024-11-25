using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBark : MonoBehaviour
{
    private AudioSource audioSource;
    private float timer;
    public float barkInterval = 5f; // Tiempo entre ladridos

    void Start()
    {
        // Obtén el componente AudioSource del perrito
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= barkInterval)
        {
            Bark(); // Llama al método para reproducir el ladrido
            timer = 0f; // Reinicia el temporizador
        }
    }

    void Bark()
    {
        if (!audioSource.isPlaying) // Evita superposición de sonidos
        {
            audioSource.Play();
        }
    }
}
