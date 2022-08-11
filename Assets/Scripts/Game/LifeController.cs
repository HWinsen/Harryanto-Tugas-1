using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
{
    public class LifeController : MonoBehaviour
    {
        public int life;
        [SerializeField] private UIController _uIController;

        private void Start()
        {
            life = 3;
        }

        public void RemoveLife()
        {
            if (life == 3)
            {
                _uIController.life3.SetActive(false);
            }
            else if (life == 2)
            {
                _uIController.life2.SetActive(false);
            }
            else if (life <= 1)
            {
                _uIController.life1.SetActive(false);
            }
            life--;
            Debug.Log(life);
        }
    }
}