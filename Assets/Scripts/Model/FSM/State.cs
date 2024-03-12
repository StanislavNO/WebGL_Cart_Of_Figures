using Assets.Scripts.Model.Unit.Transitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    internal abstract class State
    {
        private List<Transition> _transitions;

        internal void Enter()
        {
            throw new NotImplementedException();
        }

        internal void Exit()
        {
            throw new NotImplementedException();
        }

        internal bool TryGetNextState(out State nextState)
        {
            foreach (var transition in _transitions)
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
