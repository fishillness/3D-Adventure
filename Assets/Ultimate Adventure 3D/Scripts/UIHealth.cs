using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private Destructible destructible;
    [SerializeField] private Image image;

    private void Start()
    {
        destructible.ChangeHitPoints.AddListener(OnChangeHitPoints);
    }

    private void OnDestroy()
    {
        destructible.ChangeHitPoints.RemoveListener(OnChangeHitPoints);
    }

    public void OnChangeHitPoints()
    {
        image.fillAmount = (float) destructible.GetHitPoints() / (float)destructible.GetMaxHitPoints();
    }
}
