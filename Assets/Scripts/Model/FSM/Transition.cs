using UnityEngine;

namespace Assets.Scripts.Model
{
    public class Transition : MonoBehaviour
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