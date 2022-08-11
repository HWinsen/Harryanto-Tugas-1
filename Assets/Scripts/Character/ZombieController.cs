using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Raycast();
        }

        protected override void Move()
        {
            transform.position += moveSpeed * Time.deltaTime * -transform.up;
        }

        protected override void Die()
        {
            // point nambah
            _scoreController.UpdateScore();
            gameObject.SetActive(false);
        }

        public void setController(ScoreController sc)
        {
            _scoreController = sc;
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
