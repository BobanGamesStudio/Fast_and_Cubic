using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{

    public Text forceText;
    public Slider forceSlider;

    public Text volumeText;
    public Slider volumeSlider;

    private void Start() {
        forceSlider.value = (GameData.SideForce - 50) * 4;
        volumeSlider.value = GameData.Volume * 100;
    }

    void Update() 
    {
        forceText.text = "Side Force:  " + (forceSlider.value).ToString("0");
        GameData.SideForce = 50 + forceSlider.value/4;

        volumeText.text = "Volume:  " + (volumeSlider.value).ToString("0");
        GameData.Volume = volumeSlider.value/100;

        FindObjectOfType<AudioManager>().RefreshVolume();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene( 0 );
    }
}
