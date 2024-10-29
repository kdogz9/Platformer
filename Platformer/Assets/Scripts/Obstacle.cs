using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObstacleNS
{
    public class Obstacle : MonoBehaviour
    {
        public bool playerDead;
        private TMP_Text deathText;

        private void Start()
        {
            deathText = GameObject.Find("DeathText").GetComponent<TMP_Text>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider)
            {
                playerDead = true;
                deathText.text = "You Died!";
                Destroy(collision.gameObject);
                StartCoroutine(RestartLevel());
            }
        }

        private IEnumerator RestartLevel()
        {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } 
    }
}
