using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
{
    public class SafeZoneController : MonoBehaviour
    {
        [SerializeField] private LifeController _lifeController;
        [SerializeField] private ScoreController _scoreController;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Zombie"))
            {
                // Kurangin darah
                _lifeController.RemoveLife();
            }
            else if (collision.CompareTag("Human"))
            {
                _scoreController.BonusScore();
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            collision.gameObject.SetActive(false);
        }
    }
}