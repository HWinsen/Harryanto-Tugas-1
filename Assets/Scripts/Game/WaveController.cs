using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Agate.TapZombie.Game
{
    public class WaveController : MonoBehaviour
    {
        private float _waveDuration;
        private float _waveCountdown;
        private int _waveCount;

        [SerializeField] private TMP_Text _waveTMP;
        public bool isActive;

        // Start is called before the first frame update
        void Start()
        {
            isActive = true;
            _waveDuration = 10f;
            _waveCountdown = 5f;
            _waveCount = 1;
            _waveTMP.SetText("Wave: " + _waveCount.ToString());
        }

        // Update is called once per frame
        void Update()
        {
            if (isActive)
            {
                _waveTMP.SetText("Wave: " + _waveCount.ToString());
                _waveDuration -= Time.deltaTime;
                if (_waveDuration <= 0f)
                {
                    isActive = false;
                }
            }
            else
            {
                _waveTMP.SetText("Next wave in: " + _waveCountdown.ToString("00"));
                _waveCountdown -= Time.deltaTime;
                if (_waveCountdown <= 0f)
                {
                    _waveCount++;
                    isActive = true;
                    _waveDuration = 10f;
                    _waveCountdown = 5f;
                }
            }
        }

    }
}