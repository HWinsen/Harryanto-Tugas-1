using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.5f;
    [SerializeField] private GameManager _gameManager;

    private void Update()
    {
        transform.position += _moveSpeed * Time.deltaTime * -transform.up;
    }

    public void Kill()
    {
        _gameManager.Lose();
    }

    private void OnMouseDown()
    {
        Kill();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            gameObject.SetActive(false);
        }
    }
}
