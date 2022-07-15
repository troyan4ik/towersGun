using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] private Transform shootPosition;
    [SerializeField] private GameObject bullet;
    [SerializeField] private bool canShoot = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && canShoot == true)
          //  StartCoroutine(timeShoot());
        
            

    }

    private IEnumerator timeShoot()
    {
        canShoot = false;
        Instantiate(bullet, shootPosition.position, transform.rotation);
        yield return new WaitForSeconds(0.9f);
        canShoot = true;
    }

    public void buttonShoot()
    {
        if(canShoot == true)
        {
            StartCoroutine(timeShoot());
           
        }
    }
}
