using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveController : MonoBehaviour
{
    private float _waveCountdown;
    private int _waveCount;
    [SerializeField] private TMP_Text _waveTMP;

    // Start is called before the first frame update
    void Start()
    {
        _waveCountdown = 10f;
        _waveCount = 1;
        _waveTMP.SetText("Wave: " + _waveCount.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        _waveCountdown -= Time.deltaTime;
        if (_waveCountdown <= 0)
        {
            Debug.Log(_waveCountdown);
            _waveCount++;
            _waveTMP.SetText("Wave: " + _waveCount.ToString());
            _waveCountdown = 10f;
        }
    }

}
