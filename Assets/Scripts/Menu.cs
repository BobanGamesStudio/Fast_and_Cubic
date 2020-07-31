using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene( 3 );
    }   
    public void StartAbout()
    {
        SceneManager.LoadScene( 1 );
    }   
    public void StartControl()
    {
        SceneManager.LoadScene( 2 );
    }   
}
