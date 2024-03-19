using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Model.Units.Transitions
{
    public class EmptyInventoryTransition : Transition
    {
        [SerializeField] private Inventory _inventory;

        private void OnEnable()
        {
            _inventory.Emptied += OnActivate;
        }

        private void OnDisable()
        {
            _inventory.Emptied -= OnActivate;
        }

        private void OnActivate()
        {
            NeedTransit = true;
        }
    }
}