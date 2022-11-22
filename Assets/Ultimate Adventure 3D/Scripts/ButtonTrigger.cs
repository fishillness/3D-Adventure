using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Bag bag = other.GetComponent<Bag>();
        if (bag != null)
        {
            bag.AddPressedButton();
        }
    }
}
