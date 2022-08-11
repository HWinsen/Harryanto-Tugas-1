using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.TapZombie.Game;

namespace Agate.TapZombie.Character
{
    public class RobotZombieController : BaseCharacter, IRaycastable
    {
        [SerializeField] private ScoreController _scoreController;
        private float zigZagDuration;
        private float zigZagInterval = 2f;
        [SerializeField] private float newX = 5f;
        

        private void Start()
        {
            moveSpeed = 2f;
            StartCoroutine(ZigZag(zigZagInterval));
        }

        private void OnEnable()
        {
            StartCoroutine(ZigZag(zigZagInterval));
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

        protected override void Die()
        {
            // point nambah
            _scoreController.UpdateScore();
            gameObject.SetActive(false);
        }

        //public void SetController(ScoreController sc)
        //{
        //    _scoreController = sc;
        //}

        public override void Raycasts()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider != null && hit.collider.CompareTag("Zombie2"))
                {
                    Die();
                }
            }
        }

        IEnumerator ZigZag(float zigZagInterval)
        {
            while (true)
            {
                float zigZagDuration = 0;
                if (newX == 5)
                {
                    newX = -5;
                }
                else if (newX == -5)
                {
                    newX = 5;
                }

                while (zigZagDuration < zigZagInterval)
                {
                    transform.position = new Vector2(Mathf.Lerp(transform.position.x, newX, Time.deltaTime * 1), transform.position.y);
                    zigZagDuration += Time.deltaTime;
                    yield return null;
                }
            }
        }
    }
}
