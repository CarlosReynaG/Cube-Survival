using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour {

    bool gameIsOver = false;

    public float restartTimer = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
        public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true; 
            Debug.Log("Game Over");
            Invoke("Remake", restartTimer);
        }
    }

    void Remake ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
