using Assets.Scripts.Model.Units;
using UnityEngine;
using System;

namespace Assets.Scripts.Model
{
    internal class InteractiveState : State 
    {
        [SerializeField] private RagdollController _ragdollController;
        [SerializeField] private Unit _unit;
        [SerializeField] private float _speed;

        private Ray _ray;

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
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 newPosition = (transform.position - _ray.origin);

            if (Input.GetKey(KeyCode.Mouse0))
            {
                _unit.transform.position = Vector3.MoveTowards(
                    _unit.transform.position,
                    _ray.GetPoint(newPosition.magnitude),
                    _speed * Time.deltaTime);
            }
        }
    }
}