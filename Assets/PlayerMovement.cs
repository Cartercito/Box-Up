using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Input.mousePosition;
        if (screenPos.x < Screen.width && screenPos.x > 0 && screenPos.y < Screen.height && screenPos.y > 0)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(screenPos);
            pos.y = this.transform.position.y;
            this.transform.position = pos;
        }
        
    }
}
