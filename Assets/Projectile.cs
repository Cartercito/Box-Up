using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float height;
    public float width;
    // Start is called before the first frame update
    private void Start()
    {
        Bounds bounds = this.GetComponent<Collider2D>().bounds;
        height = bounds.max.y - bounds.min.y;
        width = bounds.max.x - bounds.min.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
