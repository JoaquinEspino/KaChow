using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSystem : MonoBehaviour
{

    [HideInInspector]
    public float hungerState;
    [SerializeField]
    public float maxHunger = 10;
    [HideInInspector]
    public bool isEating, isHungry;
    public GameObject player;
    public Image icon;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isEating = isHungry = false;
        hungerState = maxHunger;
        icon = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        HungerManager();
    }

    void HungerManager()
    {
        //Debug.Log(hungerState);
        animator.SetBool("isHungry", isHungry);
        hungerState -= 1 * Time.deltaTime;
        if (isEating)
        {
            hungerState = maxHunger;
        }

        if(hungerState<=0)
        {
            hungerState = 0;
            isHungry = true;
        }

        if (hungerState > 0)
        {
            isHungry = false;
        }


    }
}
