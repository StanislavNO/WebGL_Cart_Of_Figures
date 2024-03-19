using UnityEngine;
using System;

namespace Assets.Scripts.Model.Units.States
{
    public class ResourceSearchState : MonoBehaviour
    {
        private const string Moving = "Moving";

        [SerializeField] private Animator _animator;
        [SerializeField] private ResourceSpawner _spawner;
        [SerializeField] private float _speed;

        private void Start()
        {
            _animator.SetTrigger(Moving);
            RotateToTarget();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.position = Vector3.MoveTowards(
                            transform.position,
                            _spawner.transform.position,
                            _speed * Time.deltaTime);
        }

        private void RotateToTarget()
        {
            Vector3 direction = _spawner.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);

            transform.rotation = rotation;
        }
    }
}