using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMan : MonoBehaviour
{
    public int collisionDamage;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Man")
        {
            healthMan currentHp = collision.gameObject.GetComponent<healthMan>();
            currentHp.takeHit(collisionDamage);
           
        }
    }
}
