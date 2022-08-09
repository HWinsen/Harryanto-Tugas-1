using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnObject;
    [SerializeField] private float _spawnInterval;
    private Vector2 _randomSpawnPosition;
    private float _spawnTimer;
    private int _randomSpawnObject;

    // Start is called before the first frame update
    void Start()
    {
        _spawnTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _randomSpawnObject = Random.Range(0, _spawnObject.Length);
        _randomSpawnPosition = new Vector2(Random.Range(-5, 5), transform.position.y);
        _spawnTimer += Time.deltaTime;
        if (_spawnTimer >= _spawnInterval)
        {
            //Debug.Log(_spawnTimer >= _spawnInterval);
            //spawnObject = ObjectPooler.Instance.GetPooledObject();
            //if (spawnObject != null)
            //{
            //    spawnObject.transform.SetPositionAndRotation(spawnerPositionList[randomSpawnPosition], Quaternion.identity);
            //    spawnObject.SetActive(true);

            //}
            Instantiate(_spawnObject[_randomSpawnObject], _randomSpawnPosition, Quaternion.identity);
            _spawnTimer = 0f;
        }
    }
}
