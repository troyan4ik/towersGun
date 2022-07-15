using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingMan : MonoBehaviour
{
    [SerializeField] private Transform shootPosition;
    [SerializeField] private GameObject bullet;
    float fireRate;
    float nextFire;

    private void Start()
    {
        fireRate = 3.2f;
        nextFire = Time.time;
    }

    private void Update()
    {
        cheakTime();
    }

    void cheakTime()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bullet, shootPosition.position, transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }


}
