using SimpleFPS;
using UnityEngine;
using UnityEngine.Events;

public class TriggerForTime : MonoBehaviour
{
    [SerializeField] private float timeOfAction;
    public UnityEvent Enter;
    public UnityEvent Exit;
    public UnityEvent TimeIsUp;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeOfAction)
        {
            TimeIsUp.Invoke();

            timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Enter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Exit.Invoke();
        }
    }
}
