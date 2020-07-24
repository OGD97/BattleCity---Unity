using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    private LevelManager gameLevelManagerP;
    public int enemyValue;

void Start()
{
    gameLevelManagerP = FindObjectOfType<LevelManager>();
}

       void OnCollisionEnter2D(Collision2D col)
   {
       if (col.gameObject.tag == "brick" || col.gameObject.tag == "Enemy") //add enemy
       {  
          // gameLevelManager.AddPlayer(playervalue);
           Destroy(col.gameObject);

           if(col.gameObject.tag == "Enemy")
           {
               gameLevelManagerP.AddEnemy(enemyValue);
           }
       }
   }
}


