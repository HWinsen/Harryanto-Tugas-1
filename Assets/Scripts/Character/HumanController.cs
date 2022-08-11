using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.TapZombie.Game;

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
            Raycasts();
        }

        protected override void Move()
        {
            transform.position += moveSpeed * Time.deltaTime * -transform.up;
        }

        protected override void Die(GameObject RaycastedHuman)
        {
            _gameManager.Lose();
            RaycastedHuman.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Zombie") || collision.CompareTag("Zombie2"))
            {
                gameObject.SetActive(false);
            }
        }

        public override void Raycasts()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider != null && hit.collider.CompareTag("Human"))
                {
                    Die(hit.collider.gameObject);
                }
            }
        }
    }
}