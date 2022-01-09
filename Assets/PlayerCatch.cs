using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCatch : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
       // collision.transform.position = this.transform.position;
        collision.transform.SetParent(transform);
        Destroy(collision.GetComponent<Rigidbody2D>());
        Destroy(collision);
    }

}
