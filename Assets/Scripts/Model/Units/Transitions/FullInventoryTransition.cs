﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Model.Units.Transitions
{
    public class FullInventoryTransition : Transition
    {
        [SerializeField] private Inventory _inventory;

        private void OnEnable()
        {
            _inventory.Filled += OnActivate;
        }

        private void OnDisable()
        {
            _inventory.Filled -= OnActivate;
        }

        private void OnActivate()
        {
            NeedTransit = true;
        }
    }
}