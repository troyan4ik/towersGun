using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthMan : MonoBehaviour
{
  
    public int currentHp;
    public int maxHp;

    public void takeHit(int damage)
    {
        currentHp -= damage;
        if(currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
