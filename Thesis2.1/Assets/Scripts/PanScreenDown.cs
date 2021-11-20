using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScreenDown : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destroyable;
    // Start is called before the first frame update
    public void StartPanDown()
    {
        print("pan");
        transform.LeanMoveLocal(new Vector2(0, -2550), 0.25f).setOnComplete(DestroyObj);
    }

    void DestroyObj()
    {
        Destroy(destroyable);
    }
}
