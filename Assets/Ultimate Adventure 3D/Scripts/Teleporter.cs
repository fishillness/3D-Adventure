using SimpleFPS;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter target;
    [HideInInspector] public bool IsReceive;
    private new AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (IsReceive == true) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            target.IsReceive = true;

            audio.Play();
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
