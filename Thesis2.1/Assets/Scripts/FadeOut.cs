using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public CanvasGroup background;
    public GameObject destroyable;
    // Start is called before the first frame update
    public void StartFadeOut()
    {
        background.LeanAlpha(0, 0.25f).setOnComplete(DestroyObj);
    }

    void DestroyObj()
    {
        Destroy(destroyable);
    }
}
