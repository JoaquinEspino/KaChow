using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScreenRight : MonoBehaviour
{
    public GameObject destroyable;
    // Start is called before the first frame update
    public void StartPanRight()
    {
        print("pan");
        transform.LeanMoveLocal(new Vector2(1449, 0), 0.25f).setOnComplete(DestroyObj);
    }

    void DestroyObj()
    {
        Destroy(destroyable);
    }
}
