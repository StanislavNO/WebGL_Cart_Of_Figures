using UnityEngine;

namespace Assets.Scripts.Model
{
    internal class Transition : MonoBehaviour
    {
        [SerializeField] private State _nextState;

        public State TargetState => _nextState;
        public bool NeedTransit { get; protected set; }

        private void OnEnable()
        {
            NeedTransit = false;
        }
    }
}