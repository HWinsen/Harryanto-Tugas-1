using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    private float _waveCountdown;
    private int _waveCount;

    // Start is called before the first frame update
    void Start()
    {
        _waveCountdown = 10f;
        _waveCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        _waveCountdown -= Time.deltaTime;
        if (_waveCountdown <= 0)
        {
            _waveCount++;
            _waveCountdown = 10f;
        }
    }

}
