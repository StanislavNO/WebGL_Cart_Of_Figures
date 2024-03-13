using System;
using UnityEngine;

namespace Assets.Scripts.Model.Unit.Transitions
{
    [RequireComponent(typeof(Collider))]
    internal class InputTransition : Transition, IInteractable
    {
        public void HandleClick()
        {
            NeedTransit = true;
        }
    }
}
