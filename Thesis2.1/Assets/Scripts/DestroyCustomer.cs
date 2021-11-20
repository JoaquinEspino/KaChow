using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCustomer : MonoBehaviour
{
    public GameObject customer;
    public bool isStandingOnTrigger;
    // Start is called before the first frame update
    void Start()
    {
        isStandingOnTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        isStandingOnTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        isStandingOnTrigger = false;
    }
}
