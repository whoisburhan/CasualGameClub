using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GS.FreeSweeper
{
    public class UI_Manager : MonoBehaviour
    {
        private void OnEnable()
        {
            GameManager.OnScoreUpdate += UpdateScore;
        }

        private void OnDisable()
        {
            GameManager.OnScoreUpdate -= UpdateScore;
        }

        public void UpdateScore(int score)
        {
            Debug.Log("SCORE IS : " + score);
        }
    }
}