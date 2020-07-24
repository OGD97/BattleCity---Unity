using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public LevelManager enemykills;
    bool gameEnded = false;

    public void EndGame()
    {
        //  if (enemykills == 1)
        //  {
        //      gameEnded = true;
        //      Restart();
        //  }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
