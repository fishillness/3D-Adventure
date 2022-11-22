using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZone : MonoBehaviour
{
    [SerializeField] private int health;
    private Destructible destructible;
    private void OnTriggerEnter(Collider other)
    {
        destructible = other.GetComponent<Destructible>();
        if (destructible != null)
        {
            destructible.ApplyHealth(health);
        }
    }

}
