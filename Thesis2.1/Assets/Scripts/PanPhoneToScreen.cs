using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanPhoneToScreen : MonoBehaviour
{
    bool isOnScreen;
    // Start is called before the first frame update
    void Start()
    {
        isOnScreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        PanPhone();
    }

    public void PanPhone()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isOnScreen)
            {
                transform.LeanMoveLocal(new Vector2(0, -950), 0.25f);
                
            }
            else
            {
                transform.LeanMoveLocal(new Vector2(0, 0), 0.25f);
            }

            isOnScreen = !isOnScreen;
        }
    }
}
