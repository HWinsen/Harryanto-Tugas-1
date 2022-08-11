using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.TapZombie.Game;

namespace Agate.TapZombie.Character
{
    public class ZombieController : BaseCharacter, IRaycastable
    {
        [SerializeField] private ScoreController _scoreController;

        private void Start()
        {
            moveSpeed = 2f;
        }

        protected override void Update()
        {
            Move();
            if (Input.GetMouseButtonDown(0))
            {
                Raycasts();
            }
        }

        protected override void Move()
        {
            transform.position += moveSpeed * Time.deltaTime * -transform.up;
        }

        protected override void Die(GameObject RaycastedZombie)
        {
            // point nambah
            _scoreController.UpdateScore();
            RaycastedZombie.SetActive(false);
        }

        //public void SetController(ScoreController sc)
        //{
        //    _scoreController = sc;
        //}

        public override void Raycasts()
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.CompareTag("Zombie"))
            {
                Die(hit.collider.gameObject);
            }
        }
    }
}
