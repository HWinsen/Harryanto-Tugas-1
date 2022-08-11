using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
{
    public class ZombieController : BaseCharacter
    {
        [SerializeField] private ScoreController _scoreController;

        private void Start()
        {
            _moveSpeed = 2f;
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
}
