using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 target;

    private void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(target), speed * Time.deltaTime);
    }
}
