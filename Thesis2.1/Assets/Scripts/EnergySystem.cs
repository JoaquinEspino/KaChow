using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergySystem : MonoBehaviour
{
    [HideInInspector]
    public float energyState;
    [HideInInspector]
    public bool isResting, isMoving, isHungry, isGrumpy, isTired;
    public GameObject player, hunger, mood;
    public Image icon;
    public Animator animator;
    [SerializeField]
    public float maxEnergy;
    // Start is called before the first frame update
    void Start()
    {
        icon = GetComponent<Image>();
        isMoving = isHungry = isGrumpy = isTired = false;
        energyState = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustEnergy();


    }

    void AdjustEnergy()
    {
        
        animator.SetBool("isTired", isTired);
        Vector3 move = player.GetComponent<PlayerMovement>().move;
        Debug.Log(energyState);
        if (Mathf.Abs(move.x) > 0 || Mathf.Abs(move.z) > 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving && energyState >= 0)
        {
            energyState -= 1 * Time.deltaTime;
        }

        if(isHungry)
        {
            energyState -= .5f * Time.deltaTime;
        }

        if (isGrumpy)
        {
            energyState -= .5f * Time.deltaTime;
        }

        if (!isMoving && energyState <= maxEnergy)
        {
            energyState += 1 * Time.deltaTime;
        }

        if(energyState <=0)
        {
            isTired = true;
        }

        if (energyState > 0)
        {
            isTired = false;
        }

    }
}
