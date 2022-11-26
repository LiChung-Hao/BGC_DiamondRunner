using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockMouseOnceReloadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = false;
        Cursor.visible = true;
    }
}
