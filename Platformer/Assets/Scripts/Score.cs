using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
        private int score = 0; // Variable to hold the score
        public TMP_Text scoreText;

        // Method to add score
        public void AddScore(int scoreToAdd)
        {
            score += scoreToAdd; // Update the score
            UpdateDisplay(); // Update the display
           // ScoreText.text = "Score: " + score;
        }

        // Method to get the current score // Variable to hold the text display
        public int GetScore()
        {
            return score; // Return the current score
        }

        // Method to update the display text
        private void UpdateDisplay()
        {
           scoreText.text = "Score: " + score;  // Update display text
                                              // Here you would include code to actually update the UI
        }
    }


