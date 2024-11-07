using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private TMP_Text WinText;

    private void Start()
    {
        WinText = GameObject.Find("WinText").GetComponent<TMP_Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
            WinText.text = "You have Won!";
            StartCoroutine(RestartLevel()); 
        }

    }

    private static IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
