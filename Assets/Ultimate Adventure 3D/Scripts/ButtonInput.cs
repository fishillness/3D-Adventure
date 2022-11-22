using UnityEngine;
using UnityEngine.Events;

public class ButtonInput : MonoBehaviour
{
    public bool isPress;
    public UnityEvent EscapeIsPressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
            EscapeIsPressed.Invoke();
    }
}
