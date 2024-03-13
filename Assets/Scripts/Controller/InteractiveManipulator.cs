using Assets.Scripts.Model.Unit;
using UnityEngine;
//using Color = UnityEngine.Color;


namespace Assets.Scripts.Controller
{
    public class InteractiveManipulator : MonoBehaviour
    {
        private Ray _ray;
        private RaycastHit _hit;

        private void Update()
        {
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.DrawRay(_ray.origin, _ray.direction * 100f, Color.red);

            if (Physics.Raycast(_ray, out _hit))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    if (_hit.collider.TryGetComponent(out IInteractable unit))
                    {
                        unit.HandleClick();
                    }
                }
            }

        }
    }
}