using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Model.Unit
{
    public class RagdollController : MonoBehaviour
    {
        [SerializeField] private int i;
        [SerializeField] private Animator _animator;
        [SerializeField] private Rigidbody[] _bodyParts;

        private void Awake()
        {
            foreach(var bodyPart in _bodyParts)
                bodyPart.isKinematic = true;
        }


    }
}