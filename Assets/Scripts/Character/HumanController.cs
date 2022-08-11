using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
{
    public class HumanController : BaseCharacter, IRaycastable
    {
        [SerializeField] private GameManager _gameManager;

        private void Start()
        {
            moveSpeed = 0.8f;
        }

        protected override void Update()
        {
            Move();
            Raycast();
        }

        protected override void Move()
        {
            transform.position += moveSpeed * Time.deltaTime * -transform.up;
        }

        protected override void Die()
        {
            _gameManager.Lose();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Zombie"))
            {
                gameObject.SetActive(false);
            }
        }

        public override void Raycast()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider != null)
                {
                    Die();
                    Debug.Log("Target name: " + hit.collider.name);
                }
            }
        }
    }
}