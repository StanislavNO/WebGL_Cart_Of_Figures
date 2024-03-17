using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Model
{
    public abstract class State : MonoBehaviour
    {
        [SerializeField] private List<Transition> Transitions;

        private void Awake()
        {
            enabled = false;
        }

        public void Enter()
        {
            if (enabled == false)
                enabled = true;

            foreach (var transition in Transitions)
                transition.enabled = true;
        }

        public void Exit()
        {
            if (enabled == false)
                return;

            foreach (var transition in Transitions)
                transition.enabled = false;

            enabled = false;
        }

        public bool TryGetNextState(out State nextState)
        {
            foreach (var transition in Transitions)
            {
                if (transition.NeedTransit)
                {
                    nextState = transition.TargetState;
                    return true;
                }
            }

            nextState = null;
            return false;
        }
    }
}
