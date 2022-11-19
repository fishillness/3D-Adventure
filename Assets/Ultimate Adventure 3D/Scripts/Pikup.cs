using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFPS;

public class Pikup : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();
        if (fps != null)
        {
            Destroy(gameObject);
        }
    }
}
