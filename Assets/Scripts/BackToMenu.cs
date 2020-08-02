using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void BackToMenuf()
    {
        SceneManager.LoadScene( 0 );
    }
}
