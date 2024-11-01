using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour

{
    // Variable to specify how much score to add when the egg is collected
    [SerializeField] private int scoreAmount = 10;

    [SerializeField] private AudioClip audioClip; 
    [SerializeField] private AudioSource audioSource;

    // Detects when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Try to get the Score component from the other object
        Score scoreComponent = other.GetComponent<Score>();

        // If a Score component is found, add to the score
        if (scoreComponent != null)
        {
            scoreComponent.AddScore(scoreAmount);
            audioSource.clip = audioClip;
            audioSource.Play();
            Debug.Log("EGG");
            Destroy(gameObject);
        }
    }
void Start() {
    //To give a value to audioSource we do two things
    //First, we find the Main Camera, by finding the gameobject with the MainCamera tag
    //We then use GetComponent in Children to reference the child object with the Audio Source
    audioSource = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<AudioSource>(); 
} 
}
