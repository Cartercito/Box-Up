using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float height;
    // Start is called before the first frame update
    private void Start()
    {
        Bounds bounds = this.GetComponent<Collider2D>().bounds;
        height = bounds.max.y - bounds.min.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
