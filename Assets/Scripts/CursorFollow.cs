using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow : MonoBehaviour
{

    public RectTransform cursorFollowObjeect;
    private void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        cursorFollowObjeect.position = Input.mousePosition;
    }

}
