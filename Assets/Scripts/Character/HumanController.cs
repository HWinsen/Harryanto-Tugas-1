using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
{
    public class HumanController : BaseCharacter
    {
        [SerializeField] private GameManager _gameManager;

        private void Start()
        {
            _moveSpeed = 0.8f;
        }

        private void Update()
        {
            Move();
        }

        protected override void Move()
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
}