using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2;
    [SerializeField] private ScoreController _scoreController;

    private void Start()
    {
    }

    private void Update()
    {
        transform.position += _moveSpeed * Time.deltaTime * -transform.up;
    }
    public void Kill()
    {
        // point nambah
        _scoreController.UpdateScore();
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        Kill();
    }

    public void setController(ScoreController sc)
    {
        _scoreController = sc;
    }
}
