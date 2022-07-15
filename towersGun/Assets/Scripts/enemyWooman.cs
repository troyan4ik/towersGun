using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWooman : MonoBehaviour
{
    public int collisionDamage;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Wooman")
        {
            healthWooman currentHp = collision.gameObject.GetComponent<healthWooman>();
            currentHp.takeHit(collisionDamage);

        }
    }
}
