using UnityEngine;

namespace Assets.Scripts.Model
{
    internal class MoverState : State
    {
        [SerializeField] private float _speed = 5;
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
                _target = _homePoint;
            else
                _target = _resourcePoint;

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