using System;
using UnityEngine;

namespace Assets.Scripts.Model.Units.Transitions
{
    internal class InputTransition : Transition, IInteractable
    {
        public void HandleClick()
        {
            NeedTransit = true;
        }
    }
}
