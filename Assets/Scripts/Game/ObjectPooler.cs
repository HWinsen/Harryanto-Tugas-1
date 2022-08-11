using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
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

        public List<GameObject> pooledObjects;
        [SerializeField] private GameObject[] _spawnObject;
        private int _randomSpawnObject;
        //public AssetReference ball;

        public int amountToPool;

        // Start is called before the first frame update
        void Start()
        {
            //Addressables.InitializeAsync();

            pooledObjects = new List<GameObject>();

            for (int i = 0; i < amountToPool; i++)
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
                pooledObjects.Add(obj);
                obj.transform.parent = gameObject.transform;
            }

        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < amountToPool; i++)
            {
                if (!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            }
            return null;
        }

    }
}