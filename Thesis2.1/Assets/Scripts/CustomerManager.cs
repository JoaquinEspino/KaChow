using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] m_SpawnPoints;
    public GameObject m_CustomerPrefab;
    public GameObject customerTrigger;
    GameObject customer;
    void Start()
    {
        SpawnNewCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyCustomer triggerReference = customerTrigger.GetComponent<DestroyCustomer>();
        bool isOnTrigger = triggerReference.isStandingOnTrigger;
        if (isOnTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(customer);
                print("Destroyed");
            }
        }
    }

    void SpawnNewCustomer()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length - 1));
        customer = Instantiate(m_CustomerPrefab, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);

    }
}
