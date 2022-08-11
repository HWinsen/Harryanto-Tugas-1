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
            life--;
            Debug.Log(life);
            _uIController.SetLifeInactive(life);
        }
    }
}