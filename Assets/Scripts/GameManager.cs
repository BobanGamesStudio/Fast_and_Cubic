using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    bool gameCompleted = false;

    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;

    public float startDelay = 3f;

    void start()
    {
        
    }

    public void CompleteLevel()
    {
        if(gameHasEnded == false)
        {
            gameCompleted = true;
            CompleteLevelUI.SetActive(true);
        }
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            GameData.PlayerDeaths += 1;
            Invoke("Restart", restartDelay);
        }   
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update() 
    {
        if(Input.GetKey("o") | Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene( 0 );
        }

        if(gameHasEnded == false & gameCompleted == false)
        {
            GameData.GameTime += Time.deltaTime;
        }
    }
}
