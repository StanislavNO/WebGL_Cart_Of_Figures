using UnityEngine;

namespace Assets.Scripts.Model
{
    internal class StateMachine : MonoBehaviour
    {
        [SerializeField] State _startState;

        private State _nextState;

        public State CurrentState { get; private set; }

        private void Start()
        {
            CurrentState = _startState;
            Initialize(CurrentState);
        }

        private void Update()
        {
            if (CurrentState == null)
                return;

            if (CurrentState.TryGetNextState(out _nextState))
                ChangeState(_nextState);
        }

        private void Initialize(State startState)
        {
            CurrentState = startState;
            CurrentState?.Enter();
        }

        private void ChangeState(State nextState)
        {
            if (nextState != null)
                CurrentState?.Exit();

            CurrentState = nextState;
            CurrentState?.Enter();
        }
    }
}