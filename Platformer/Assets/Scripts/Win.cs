using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    private TMP_Text winText;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
            winText.text = "You have Won!";
            Destroy(collision.gameObject);
        }
    }
}
