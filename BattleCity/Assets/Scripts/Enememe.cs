using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enememe : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float fireRate;
    public float nextFire;

     public float bulletForce = 20f;

    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    void Update()
    {
        CheckTimetoFire();
    }

    void CheckTimetoFire()
    {
        if(Time.time > nextFire)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
       rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet,2.5f);
            
            nextFire = Time.time + fireRate;
        }
    }

}
