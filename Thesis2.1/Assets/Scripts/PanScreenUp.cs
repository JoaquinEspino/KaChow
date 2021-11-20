using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScreenUp : MonoBehaviour
{
    public GameObject destroyable;
    public void StartPanUp()
    {
        print("pan");
        transform.LeanMoveLocal(new Vector2(0, 0), 0.25f).setOnComplete(DestroyObj);
    }

    void DestroyObj()
    {
        Destroy(destroyable);
    }
}
