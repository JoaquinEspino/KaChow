using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    // Start is called before the first frame update
    public Image image;
    int counter;
    void Start()
    {
        image = GetComponent<Image>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fade()
    {
        var tempColor = image.color;
        while(counter > 1)
        {
            
        }
        tempColor.a = 0f;
        image.color = tempColor;
    }
}
