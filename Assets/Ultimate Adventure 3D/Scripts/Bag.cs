using UnityEngine;
using UnityEngine.Events;

public class Bag : MonoBehaviour
{
    private int amountKey;
    private int amountPressedButton;
    public UnityEvent ChangeAmountKey;

    public void AddKey (int amount)
    {
        amountKey += amount;
        ChangeAmountKey.Invoke();
    }

    public bool DrawKey(int amount)
    {
        if (amountKey - amount < 0) return false;

        amountKey -= amount;
        ChangeAmountKey.Invoke();
        return true;
    }

    public int GetAmountKey()
    {
        return amountKey;
    }

    public void AddPressedButton()
    {
        amountPressedButton++;
    }
    public bool DrawPressedButton(int amount)
    {
        if (amountPressedButton - amount < 0) return false;

        amountPressedButton -= amount;
        return true;
    }
    public int GetAmountPressedButton()
    {
        return amountPressedButton;
    }
}
