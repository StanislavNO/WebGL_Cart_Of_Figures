using Assets.Scripts.Model.Unit;
using System;
using UnityEngine;

namespace Assets.Scripts.Model
{
    internal class MoverState : State , IMover
    {
        [SerializeField] private float _speed = 5;
        [SerializeField] private Transform _homePoint;
        [SerializeField] private Transform _resourcePoint;

        private Transform _target;
        private Transform _transform;

        public event Action Moving;
        public event Action Carrying;

        private void Awake()
        {
            _transform = transform;
        }

        private void OnEnable()
        {
            _target = _resourcePoint;
            Moving?.Invoke();
            RotateToTarget();
        }

        private void Update()
        {
            if (_target == null)
                return;

            Move();

            if (_transform.position.x == _target.position.x &&
                _transform.position.z == _target.position.z)
                ChangeTarget();
        }

        private void Move()
        {
            _transform.position = Vector3.MoveTowards(
                            _transform.position,
                            _target.position,
                            _speed * Time.deltaTime);
        }

        private void ChangeTarget()
        {
            if (_target == null)
                return;

            if (_target == _resourcePoint)
            {
                _target = _homePoint;
                Carrying?.Invoke();
            }
            else
            {
                _target = _resourcePoint;
                Moving?.Invoke();
            }

            RotateToTarget();
        }

        private void RotateToTarget()
        {
            Vector3 direction = _target.position - _transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);

            _transform.rotation = rotation;
        }
    }
}