using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Agate.TapZombie.Game
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreTMP;

        private int score = 0;

        // Update is called once per frame
        void Update()
        {
            _scoreTMP.SetText("Score: " + score.ToString());
        }

        public void UpdateScore()
        {
            score += 100;
        }

        public void BonusScore()
        {
            score += 500;
        }
    }
}