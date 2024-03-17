using Assets.Scripts.Model.Units;
using System;
using UnityEngine;

namespace Assets.Scripts.Model
{
    internal class InteractiveState : State 
    {
        [SerializeField] private RagdollController _ragdollController;

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }

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