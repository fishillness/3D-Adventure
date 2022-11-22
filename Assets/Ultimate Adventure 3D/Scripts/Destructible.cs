using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] private int maxHitPoints;
    [SerializeField] private GameObject impactEffect;   ///
    public UnityEvent Die;
    public UnityEvent ChangeHitPoints;
    private int hitPoints;
    private void Start()
    {
        DontDestroyOnLoad(impactEffect);
        hitPoints = maxHitPoints;
        ChangeHitPoints.Invoke();
    }
    public void ApplyDamage(int damage)
    {
        hitPoints -= damage;
        ChangeHitPoints.Invoke();

        if (hitPoints <= 0)
        {
            Kill();
        }
    }
    public void ApplyHealth(int health)
    {
        hitPoints += health;
        if (hitPoints >= maxHitPoints)
            hitPoints = maxHitPoints;

        ChangeHitPoints.Invoke();
    }

    public void Kill()
    {
        hitPoints = 0;
        Instantiate(impactEffect);  ////
        ChangeHitPoints.Invoke();
        Die.Invoke();
    }

    public int GetHitPoints()
    {
        return hitPoints;
    }
    public int GetMaxHitPoints()
    {
        return maxHitPoints;
    }
}
