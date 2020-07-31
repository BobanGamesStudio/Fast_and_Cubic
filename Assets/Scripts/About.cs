using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene( 0 );
    }
}
