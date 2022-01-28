using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float xBoundary;
    private void Start()
    {
        Bounds bounds =  GameObject.FindObjectOfType<DropOff>().GetComponent<Collider2D>().bounds;
        xBoundary = bounds.extents.x + bounds.center.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Input.mousePosition;
        if (screenPos.x < Screen.width && screenPos.x > 0 && screenPos.y < Screen.height && screenPos.y > 0)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(screenPos);
           if (pos.x >= xBoundary)
            {
                pos.y = this.transform.position.y;
                this.transform.position = pos;
            }
            
        }
        
    }
}
