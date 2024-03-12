using UnityEngine;

namespace Assets.Scripts.Model
{
    internal class TargetMoverState : State
    {
        [SerializeField] private float _speed = 1;
        [SerializeField] private Transform _homePoint;
        [SerializeField] private Transform _resourcePoint;

        private Transform _target;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void OnEnable()
        {
            _target = _resourcePoint;
        }

        private void Update()
        {
            if (_target == null)
                return;

            Move();

            if (_transform.position == _target.position)
                ChangeTarget();
        }

        private void Move()
        {
            transform.position = Vector3.MoveTowards(
                            _transform.position,
                            _target.position,
                            _speed * Time.deltaTime);
        }

        private void ChangeTarget()
        {
            if (_target == null)
                return;

            if (_target == _resourcePoint)
                _target = _homePoint;
            else
                _target = _resourcePoint;
        }
    }
}