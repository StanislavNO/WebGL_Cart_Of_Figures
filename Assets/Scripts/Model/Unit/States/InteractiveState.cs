using UnityEngine;

namespace Assets.Scripts.Model.Unit.States
{
    internal class InteractiveState : State
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {


                Move();
            }
        }

        private void Move()
        {

        }
    }
}