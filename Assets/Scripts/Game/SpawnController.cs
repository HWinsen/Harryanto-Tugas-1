using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Game
{
    public class SpawnController : MonoBehaviour
    {
        // Object Pool
        [SerializeField] private ObjectPooler _objectPooler;
        [SerializeField] private GameObject _spawnObject;

        [SerializeField] private float _spawnInterval;
        private Vector2 _randomSpawnPosition;
        private float _spawnTimer;
        //private int _randomSpawnObject;

        [SerializeField] private WaveController _waveController;

        // pasang kembali scorecontroller
        //private ScoreController sc;

        // Start is called before the first frame update
        void Start()
        {
            _objectPooler = ObjectPooler.Instance;
            _spawnTimer = 0f;
        }

        // Update is called once per frame
        void Update()
        {
            // Object Pooling
            if (_waveController.isActive)
            {
                _randomSpawnPosition = new Vector2(Random.Range(-5, 5), transform.position.y);
                _spawnTimer += Time.deltaTime;
                if (_spawnTimer >= _spawnInterval)
                {
                    _spawnObject = ObjectPooler.Instance.GetPooledObject();
                    if (_spawnObject != null)
                    {
                        _spawnObject.transform.SetPositionAndRotation(_randomSpawnPosition, Quaternion.identity);
                        _spawnObject.SetActive(true);
                    }

                    //var GO = Instantiate(_spawnObject[_randomSpawnObject], _randomSpawnPosition, Quaternion.identity);
                    //GO.GetComponent<ZombieController>().setController(sc);

                    _spawnTimer = 0f;
                }
            }
        }
    }
}