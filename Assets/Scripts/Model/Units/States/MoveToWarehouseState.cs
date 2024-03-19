using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Model.Units.States
{
    public class MoveToWarehouseState : MonoBehaviour
    {
        private const string Carrying = "Carrying";

        [SerializeField] private float _speed;
        [SerializeField] private Animator _animator;
        [SerializeField] private Warehouse _warehouse;
        [SerializeField] private Inventory _inventory;

        private void Start()
        {
            _animator.SetTrigger(Carrying);
            RotateToTarget();
        }

        private void Update()
        {
            Move();
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.TryGetComponent(out Warehouse _))
                _inventory.Delete();
        }

        private void Move()
        {
            transform.position = Vector3.MoveTowards(
                            transform.position,
                            _warehouse.transform.position,
                            _speed * Time.deltaTime);
        }

        private void RotateToTarget()
        {
            Vector3 direction = _warehouse.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);

            transform.rotation = rotation;
        }
    }
}