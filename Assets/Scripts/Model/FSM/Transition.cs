using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Model
{
    internal class Transition : MonoBehaviour
    {
        public bool NeedTransit { get; internal set; }
        public State TargetState { get; internal set; }
    }
}