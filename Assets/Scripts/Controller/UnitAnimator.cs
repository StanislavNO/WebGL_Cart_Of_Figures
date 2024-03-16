using Assets.Scripts.Model.Unit;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class UnitAnimator : MonoBehaviour
    {
        private const string Moving = "Moving";
        private const string Carrying = "Carrying";

        [SerializeField] private Animator _animator;
        [SerializeReference] private IMover _unit;
        public IMover Unit;
        [SerializeField] private IMover _nit;
        [SerializeField] private IMover _unt;
        [SerializeField] private int _t;

        //[SerializeField, Restrict(typeof(IMover))]
        //private UnityEngine.Object unit;


        private void OnEnable()
        {
            _unit.Moving += OnMove;
            _unit.Carrying += OnCarrying;
        }

        private void OnDisable()
        {
            _unit.Moving -= OnMove;
            _unit.Carrying -= OnCarrying;
        }

        private void OnMove()
        {
            _animator.SetTrigger(Moving);
        }

        private void OnCarrying()
        {
            _animator.SetTrigger(Carrying);
        }
    }
}