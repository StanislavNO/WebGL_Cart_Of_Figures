using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Model
{
    public class RagdollController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private Rigidbody[] _bodyParts;

        private void Awake()
        {
            foreach(var bodyPart in _bodyParts)
                bodyPart.isKinematic = true;

            enabled = false;
        }

        private void OnEnable()
        {
            _animator.enabled = false;

            foreach (var bodyPart in _bodyParts)
                bodyPart.isKinematic = false;
        }

        private void OnDisable()
        {
            _animator.enabled = true;
        }
    }
}