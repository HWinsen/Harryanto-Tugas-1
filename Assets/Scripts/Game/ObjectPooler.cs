using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Game
{
    public class ObjectPooler : MonoBehaviour
    {
        #region Singleton

        public static ObjectPooler Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        [SerializeField] private WaveController _waveController;
        [SerializeField] private List<GameObject> _pooledObjects;
        [SerializeField] private GameObject[] _spawnObject;
        private int _randomSpawnObject;
        //public AssetReference ball;

        [SerializeField] private int _amountToPool;

        void Start()
        {
            //Addressables.InitializeAsync();
            _pooledObjects = new List<GameObject>();
            Pool();
        }

        public GameObject GetPooledObject()
        {
            int _randomIndex = Random.Range(0, _amountToPool);

            if (!_pooledObjects[_randomIndex].activeInHierarchy)
            {
                return _pooledObjects[_randomIndex];
            }
            else
            {
                GetPooledObject();
            }

            return null;
        }

        public void Pool()
        {
            for (int i = 0; i < _amountToPool; i++)
            {
                _randomSpawnObject = Random.Range(0, _spawnObject.Length);

                //ball.InstantiateAsync().Completed += (newBall) =>
                //{
                //    GameObject obj = newBall.Result;
                //    obj.SetActive(false);
                //    pooledObjects.Add(obj);
                //};

                GameObject obj = Instantiate(_spawnObject[_randomSpawnObject], transform.position, Quaternion.identity);
                obj.SetActive(false);
                _pooledObjects.Add(obj);
                obj.transform.parent = gameObject.transform;
            }
        }

    }
}