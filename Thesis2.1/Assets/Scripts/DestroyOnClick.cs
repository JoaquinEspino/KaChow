using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destroyable;
    public void DestroyObj()
    {
        Destroy(destroyable);
    }

}
