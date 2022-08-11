using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Game
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
                _uIController.SetLife3Inactive();
            }
            else if (life == 2)
            {
                _uIController.SetLife2Inactive();
            }
            else if (life <= 1)
            {
                _uIController.SetLife1Inactive();
            }
            life--;
            Debug.Log(life);
        }
    }
}