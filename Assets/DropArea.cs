using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropArea : MonoBehaviour
{
    public GameObject projectile;
    public float dropRate = 1.2f;
    private float lastDrop;
    
    void Update()
    {
        if (Time.time >= lastDrop + dropRate)
        {
            lastDrop = Time.time;
            BoxCollider2D col = this.GetComponent<BoxCollider2D>();
            Vector3 center = col.bounds.center;
            Vector3 extent = col.bounds.extents;
            Vector3 random = new Vector3();
            random.x = center.x + Random.Range(-extent.x, extent.x);
            random.y = center.y + Random.Range(-extent.y, extent.y);
            random.z = center.z;
            GameObject drop = GameObject.Instantiate(projectile);
            drop.transform.position = random;
        }

    }
}
