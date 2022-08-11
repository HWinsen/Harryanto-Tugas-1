using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Character
{
    public abstract class BaseCharacter : MonoBehaviour
    {
        [SerializeField] protected float _moveSpeed;

        protected abstract void Move();
    }
}