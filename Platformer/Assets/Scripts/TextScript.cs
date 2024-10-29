using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ObstacleNS;
public class TextScript : MonoBehaviour
{
    ObstacleNS.Obstacle playerDead;
    public TMP_Text deathText;
    public void DisplayDamage()
    {
        if (playerDead == true)
        {
            deathText.text = "You Died";
        }
    }
}
