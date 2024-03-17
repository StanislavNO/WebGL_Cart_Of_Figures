using Assets.Scripts.Model.Units;
using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts.Model
{
    internal class InteractiveState : State 
    {
        [SerializeField] private RagdollController _ragdollController;
        [SerializeField] private Unit _unit;
        [SerializeField] private Transform _transform;
        [SerializeField] private float _speed;

        private void OnEnable()
        {
            _ragdollController.enabled = true;
        }

        private void OnDisable()
        {
            _ragdollController.enabled = false;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                _unit.transform.position = Vector3.MoveTowards(
                    _unit.transform.position,
                    _transform.position,
                    _speed * Time.deltaTime);
            }
        }
    }
}