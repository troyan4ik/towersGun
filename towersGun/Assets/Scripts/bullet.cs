using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 7f;
    void Start()
    {
        StartCoroutine(destroyBullet());
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision. gameObject.tag == "Man")
        {
            Destroy(gameObject);
        }
    }
}
