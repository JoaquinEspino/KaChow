using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScreenLeft : MonoBehaviour
{
    public GameObject destroyable;
    // Start is called before the first frame update
    public void StartPanLeft()
    {
        print("pan");
        transform.LeanMoveLocal(new Vector2(0, 0), 0.25f).setOnComplete(DestroyObj);
    }

    void DestroyObj()
    {
        Destroy(destroyable);
    }
}
