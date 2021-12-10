using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodSystem : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]
    public float moodState;
    [HideInInspector]
    public bool isHungry, isGrumpy, isTired, isBladder, badCustomer;
    public GameObject player, hunger, bladder, energy;
    public Image icon;
    public Animator animator;
    [SerializeField]
    public float maxMoodLevel;
    void Start()
    {
        icon = GetComponent<Image>();
        isHungry = isGrumpy = isTired = isBladder = false;
        moodState = maxMoodLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AdjustMood()
    {
        animator.SetBool("isGrumpy", isGrumpy);
        Debug.Log(moodState);
        isTired = energy.GetComponent<EnergySystem>().isTired;
        isBladder = bladder.GetComponent<BladderSystem>().mustGo;
        isHungry = hunger.GetComponent<HungerSystem>().isHungry;
        if(isTired)
        {
            moodState -= 1 * Time.deltaTime;
        }

        if (isGrumpy)
        {
            moodState -= 1 * Time.deltaTime; 
        }

        if(isBladder)
        {
            moodState -= 1 * Time.deltaTime;
        }

        if(isHungry)
        {
            moodState -= 1 * Time.deltaTime;
        }

        if(badCustomer)
        {
            moodState -= 1 * Time.deltaTime;
        }

        if (moodState <= 0)
        {
            isGrumpy = true;
        }

        if (moodState > 0)
        {
            isGrumpy = false;
        }

    }
}
