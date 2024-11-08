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
        WinText = GameObject.Find("Win").GetComponent<TMP_Text>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Won");
            WinText.gameObject.SetActive(true);
            WinText.text = "You have Won!";
            StartCoroutine(RestartLevel()); 
        }

    }

    private static IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
