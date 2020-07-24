using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletCollider : MonoBehaviour
{
    private LevelManager gameLevelManagerE;
    public int coinValue;

void Start()
{
    gameLevelManagerE = FindObjectOfType<LevelManager>();
}

  void OnCollisionEnter2D (Collision2D col)
  {
      if (col.gameObject.tag == "brick" || col.gameObject.tag == "Player")
      {
         
          Destroy(col.gameObject);
          if(col.gameObject.tag == "Player")
          {
              gameLevelManagerE.AddCoins(coinValue);
              //FindObjectOfType<RestartGame>().EndGame();
          }
      }
  }
}
