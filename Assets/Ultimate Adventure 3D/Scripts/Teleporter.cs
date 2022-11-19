using SimpleFPS;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter target;
    [HideInInspector] public bool IsReceive;
    private void OnTriggerEnter(Collider other)
    {
        if (IsReceive == true) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            target.IsReceive = true;

            fps.transform.position = target.transform.position;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            IsReceive = false;
        }
    }
}
