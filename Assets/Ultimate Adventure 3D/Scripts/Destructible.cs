using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] private int hitPoints;
    public UnityEvent Die;
    public void ApplyDamage(int damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            hitPoints = 0;
            Die.Invoke();
        }
    }
}
