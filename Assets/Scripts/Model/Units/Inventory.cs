using System;
using UnityEngine;

namespace Assets.Scripts.Model
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private Transform _point;

        private Resource _resource;

        public bool IsFull { get; private set; }

        public event Action Filled;
        public event Action Emptied;

        private void Start()
        {
            IsFull = false;
        }

        private void Update()
        {
            if (IsFull && _resource != null)
                _resource.transform.position = _point.position;
        }

        public void Delete()
        {
            _resource = null;
            IsFull = false;
            Emptied?.Invoke();
        }

        public void Add(Resource resource)
        {
            if (resource == null)
                return;

            _resource = resource;
            IsFull = true;
            Filled?.Invoke();
        }
    }
}