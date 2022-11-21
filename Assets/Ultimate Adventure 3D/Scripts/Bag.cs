using UnityEngine;

public class Bag : MonoBehaviour
{
    private int amountKey;

    public void AddKey (int amount)
    {
        amountKey += amount;
    }

    public bool DrawKey(int amount)
    {
        if (amountKey - amount < 0) return false;
        amountKey -= amount;
        return true;
    }

    public int GetAmountKey()
    {
        return amountKey;
    }
}
