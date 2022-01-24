using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCatch : MonoBehaviour
{
    private int maxCarry = 6;
    public GameObject carrySpot;
    public DropOff dropOff;
    private Stack<GameObject> carryList = new Stack<GameObject>();
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Projectile>() && carryList.Count < maxCarry)
        {
           
            if (carryList.Count > 0)
            {
                float height = carryList.Peek().GetComponent<Projectile>().height;
                collision.transform.position = carryList.Peek().transform.position + new Vector3(0, height / 2.0f, 0);
            }
            else
            {
                collision.transform.position = carrySpot.transform.position;
            }
            collision.transform.SetParent(this.transform);
            Destroy(collision.GetComponent<Rigidbody2D>());
            Destroy(collision);
            carryList.Push(collision.gameObject);
        }

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && dropOff ) // left click
        {
            
            if (carryList.Count > 0 && isTouchingDropOff())
            {
                GameObject top = carryList.Pop();
                top.transform.SetParent(null);
                dropOff.stackProjectile(top.GetComponent<Projectile>());
            }
        }
    }

    private bool isTouchingDropOff()
    {
        BoxCollider2D dropCol = dropOff.GetComponent<BoxCollider2D>();
        BoxCollider2D playerCol = this.GetComponent<BoxCollider2D>();
        ContactFilter2D filter = new ContactFilter2D();
        filter.useTriggers = true;
        List<Collider2D> results = new List<Collider2D>();
        dropCol.OverlapCollider(filter, results);
        return results.Contains(playerCol);
    }

}
