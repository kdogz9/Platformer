using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    private TMP_Text WinText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
            WinText.text = "You have Won!";
            Destroy(collision.gameObject);
        }
    }
}
