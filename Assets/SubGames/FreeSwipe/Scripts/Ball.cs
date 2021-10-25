using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GS.FreeSweeper
{
    public class Ball : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Tiles"))
            {
                GameManager.Instance.ScorePoint();
            }

            if (col.CompareTag("Bomb"))
            {
                Debug.Log("GAME OVER");
            }
        }
    }
}