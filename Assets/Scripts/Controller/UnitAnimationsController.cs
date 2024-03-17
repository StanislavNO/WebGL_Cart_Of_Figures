using Assets.Scripts.Model;
using UnityEngine;
using System;

namespace Assets.Scripts.Controller
{
    public class UnitAnimationsController : MonoBehaviour
    {
        private const string Moving = "Moving";
        private const string Carrying = "Carrying";

        [SerializeField] private Animator _animator;

        public void StartMoving()
        {
            _animator.SetTrigger(Moving);
        }

        public void StartCarrying()
        {
            _animator.SetTrigger(Carrying);
        }
    }
}