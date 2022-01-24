using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOff : MonoBehaviour
{
    public GameObject stackLocation;
    private Projectile lastProj;
    public void stackProjectile(Projectile proj)
    {
        Vector3 position;
        if (lastProj)
        {
            position = lastProj.transform.position + new Vector3(0, proj.height/2.0f, 0);
        }
        else
        {
            position = stackLocation.transform.position;

        }
        proj.transform.position = position;
        lastProj = proj;
    }

}
    

