using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
{
    public abstract class BaseCharacter : MonoBehaviour, IRaycastable
    {
        [SerializeField] protected float moveSpeed;

        protected abstract void Move();
        protected abstract void Die();
        public abstract void Raycast();

        protected virtual void Update()
        {
            Raycast();
        }
    }
}