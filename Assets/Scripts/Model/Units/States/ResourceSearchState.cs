using UnityEngine;
using System;

namespace Assets.Scripts.Model.Units.States
{
    public class ResourceSearchState : State
    {
        private const string Moving = "Moving";

        [SerializeField] private float _speed;
        [SerializeField] private ResourceSpawner _spawner;
        [SerializeField] private Inventory _inventory;
        [SerializeField] private Animator _animator;

        private void Start()
        {
            _animator.SetTrigger(Moving);
            RotateToTarget();
        }

        private void Update()
        {
            Move();
        }

        private void OnTriggerEnter(Collider collider)
        {
            if(collider.TryGetComponent(out ResourceSpawner spawner))
            {
                Resource resource = spawner.GetResource();
                _inventory.Add(resource);
            }
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