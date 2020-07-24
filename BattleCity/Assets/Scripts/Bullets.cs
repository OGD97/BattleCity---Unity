// using System.Collections;
// using UnityEngine;

// public class Bullets : MonoBehaviour
// {
//     public GameObject Bullet_Emitter;
//     public GameObject Bullet;
//     public float Bullet_Forward_Force;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKeyDown("space"))
//         {   
//             GameObject Temporary_Bullet_Handler;
//             Temporary_Bullet_Handler = Instantiate(Bullet,Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

//             //Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

//             Rigidbody Temporary_RigidBody;
//             Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

//             Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

//             Destroy(Temporary_Bullet_Handler,10.0f);
            
//         }
//     }
// }




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

   
   
   // public GameObject bulletObject; //destroy object


    public float bulletForce = 20f;


    
    void Update()
    {
        if(Input.GetKeyDown("space")) //u can use GetKeyDown for rapid-fire 
        {
            Shoot();
            
        }
    }

    void Shoot()
    {
       GameObject bullet = Instantiate(bulletPrefab, firePoint.position,firePoint.rotation);

       Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
       rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet,2.5f);

//      void OnCollisionEnter2D(Collision2D col)
//    {
//        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "brick")
//        {
//            Destroy(col.gameObject);
//        }
//    }

    }
    



// void OnCollisionEnter2D(Collision2D col)     //TANK DESTROYS GAMEOBJECTS
//    {
//        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "brick")
//        {
//            Destroy(col.gameObject);
//        }
//    }



//  void OnTriggerEnter2D(Collider other)
//  {
//      if(other.collider.tag("Enemy"))
//      {
//          Destroy(other.gameObject);
//      }
//  }


  
 
}