using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public float respawnDelay;
   //public PlayerController gamePlayer;
   public int enemykills;
   public Text YouDie;


    public int playerkills;


    public int show = -1;

void OnGUI () {

    if(show == 0)
    {
        if(GUILayout.Button("Try again") ){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }
    else if (show == 1)
    {
        if(GUILayout.Button("Play again") ){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }

}

   public void AddCoins(int numberofPlayer)
   {
       enemykills += numberofPlayer;
       
       if(enemykills == 1)
       {
           YouDie.text = "YOU DIED :(";
           show = 0;
               
       }
    }
      
   

   public void AddEnemy(int numberofEnemy)
   {
       playerkills += numberofEnemy;
       if(playerkills == 5)
       {
           YouDie.text = "YOU WIN :D";
           show = 1;
               
       }

   }

}




 
