using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BladderSystem : MonoBehaviour
{
    [HideInInspector]
    public float bladderState;
    [SerializeField]
    public float maxBladder;
    [HideInInspector]
    public bool isInBathroom, mustGo;
    public GameObject player;
    public Image icon;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        maxBladder = 10;
        icon = GetComponent<Image>();
        isInBathroom = false;
        bladderState = maxBladder;
        mustGo = false;
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseBladderCount();
    }

    void DecreaseBladderCount()
    {
        animator.SetBool("mustGo", mustGo);
        bladderState -= 1 * Time.deltaTime;
        //Debug.Log(bladderState);

        if (isInBathroom)
        {
            bladderState = maxBladder;
        }

        if (bladderState <= 0)
        {
            mustGo = true;
            bladderState = 0;
        }

        if(bladderState > 0)
        {
            mustGo = false;
        }

    }

    void Fade()
    {
        float counter = 0;
        var tempColor = icon.color;
        while (counter < 10)
        {
            Debug.Log(counter);
            tempColor.a -= 0.1f;
            icon.color = tempColor;
            counter += 1 * Time.deltaTime;
        }
        counter = 1;
        while (counter > 0)
        {
            tempColor.a += 0.1f;
            icon.color = tempColor;
            counter -= 1 * Time.deltaTime;
        } 
    }
}
