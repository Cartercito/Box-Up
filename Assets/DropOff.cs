using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOff : MonoBehaviour
{
    public GameObject stackLocation;
    private Projectile lastProj;
    private Projectile bottomStack;
    private int stackSize = 8;
    private int projCount = 0;
    private int stackCount = 0;
    private int maxStacks = 3;
    public void stackProjectile(Projectile proj)
    {
       if (stackCount == maxStacks)
        {
            Object.Destroy(proj.gameObject);
            return;
        }
        Vector3 position;
        if (lastProj)
        {
            if (projCount == stackSize)
            {
                position = bottomStack.transform.position + new Vector3(proj.width, 0, 0);
                bottomStack = proj;
                projCount = 0;
                stackCount++;
                if (stackCount == maxStacks)
                {
                    Object.Destroy(proj.gameObject);
                    return;
                }
            }
            else
            {
                position = lastProj.transform.position + new Vector3(0, proj.height / 2.0f, 0);
            }
        }
        else
        {
            position = stackLocation.transform.position;
            bottomStack = proj;
        }
        projCount++;
        proj.transform.position = position;
        lastProj = proj;
    }

}
    

