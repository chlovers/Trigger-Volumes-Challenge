using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighttrigger : MonoBehaviour
{
    public GameObject targetObject;

    private void Start()
    {
        targetObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(false);
    }
}
