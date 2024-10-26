using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public TMP_Text DeathText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Ensure that only the player triggers this action
        {
            Destroy(other.gameObject);   // Destroy the entire GameObject
            DeathText.text = "You died";
            Debug.Log("You died");
        }
    }
}