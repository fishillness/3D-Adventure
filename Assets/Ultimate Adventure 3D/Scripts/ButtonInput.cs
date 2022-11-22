using UnityEngine;
using UnityEngine.Events;

public class ButtonInput : MonoBehaviour
{
    public UnityEvent EscapeIsPressed;
    public UnityEvent FIsPressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
            EscapeIsPressed.Invoke();

        if (Input.GetKeyDown(KeyCode.F) == true)
            FIsPressed.Invoke();

    }
}
